# Copyright Syncfusion Inc. 2001 - 2016. All rights reserved.
# Use of this code is subject to the terms of our license.
# A copy of the current license can be obtained at any time by e-mailing
# licensing@syncfusion.com. Any infringement will be prosecuted under
# applicable laws. 


# If you are not familiar with R you can obtain a quick introduction by downloading
# R Succinctly for free from Syncfusion - http://www.syncfusion.com/resources/techportal/ebooks/rsuccinctly
# R Succinctly is also included with this installation and is available here
# Installed Drive :\Program Files (x86)\Syncfusion\Essential Studio\XX.X.X.XX\Infrastructure\EBooks\R_Succintly.pdf OF R Succinctly
# Uncomment below lines to install necessary packages if not installed already
#install.packages("gbm")
#install.packages("devtools")
#install.packages("rJava")
#install_github(repo = "jpmml/r2pmml")
# install.packages("TH.data")

# Load below packages
library(devtools)
library(gbm)
library(rJava)
library(r2pmml)
library(TH.data)# This package is specifically loaded for GBSG2 dataset shipped within it.


# Here we directly load the breastCancer dataset installed with the "TH.data" package.
data(GBSG2)
# Omit rows with missing values
breastCancer = na.omit(GBSG2)

# Code below demonstrates loading the same dataset from a CSV file shipped with our installer.
# Please check installed samples (Data) location to set actual working directory 
# Uncomment below lines and comment out the code to read data from CSV file.
# setwd("C:/actual_data_location")
# breastCancer= read.csv("BreastCancer.csv")


# Divide dataset for training and test
trainData<-breastCancer[1:549,]
testData<-breastCancer[550:686,]

# Applying the GBM - adaboost function to predict cens
breastCancer_GBM = gbm(cens~., data=trainData,distribution="adaboost")

# Display the predicted results 
# Predict "cens" column probability for test data set
breastCancerTestProbabilities = predict.gbm(breastCancer_GBM, newdata=testData, n.trees=100,type="response")
# Display predicted probabilities 
breastCancerTestProbabilities

# PMML generation
r2pmml(breastCancer_GBM ,"BreastCancer.pmml")




# The code below is used for evaluation purpose. 
# The model is applied for original breastCancer data set and predicted results are saved in "ROutput.csv"
# "ROutput.csv" file used for comparing the R results with PMML Evaluation engine results

# Load Original "breastCancer" dataset from "TH.data" package
data(GBSG2)
# Omit rows with missing values
breastCancerOriginal = na.omit(GBSG2)

# Convert ordered factor to normal factor
breastCancerOriginal$tgrade<-factor(breastCancerOriginal$tgrade, ordered = FALSE)

# Applying GBM to entire dataset and save the results in a CSV file
breastCancerEntireProbabilities = predict.gbm(breastCancer_GBM,breastCancerOriginal, n.trees=100,type="response")

# Save predicted value in a data frame
result = data.frame(breastCancerEntireProbabilities)
names(result) = c("Predicted_censored")

# Write the results in a CSV file
write.csv(result,"ROutput.csv",quote=F)
