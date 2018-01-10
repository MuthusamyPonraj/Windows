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
# install.packages("rpart")
# install.packages("pmml")
# install.packages("gmodels")
# install.packages("randomForest") 

# Load below packages
library(rpart)
library(pmml)
library(gmodels)
library(randomForest) # This package is specifically loaded for imports85 dataset shipped within it.

# Here we directly load the imports85 dataset installed with the "mlbench" package.
data(imports85)
# Omit rows with missing values
imports<-na.omit(imports85)

# Converting Ordered factor to normal factor
imports$numOfCylinders<-factor(imports$numOfCylinders, ordered = FALSE)

# Code below demonstrates loading the same dataset from a CSV file shipped with our installer.
# Please check installed samples (Data) location to set actual working directory 
# Uncomment below lines and comment out the code to read data from CSV file.
# setwd("C:/actual_data_location")
# imports<- read.csv("Imports.csv")

# Randomizing data
imports<-imports[sample(nrow(imports)),]

# Divide dataset for training and test
importsTrain <- imports[1:124, ]
importsTest <- imports[125:155, ]

# Applying TreeModel
importsModel <- rpart( price ~., data = importsTrain)
importsModel 

# Display the predicted results
# Predict "price" column for test data set
importsTestPrediction<- predict(importsModel ,importsTest)
# Display predicted values
importsTestPrediction


# PMML generation
importsPmml<- pmml(importsModel, data = importsTrain)
write (toString (importsPmml), file="Imports.pmml")
saveXML (importsPmml, file="Imports.pmml")

# The code below is used for evaluation purpose. 
# The model is applied for original imports data set and predicted results are saved in "ROuput.csv"
# "ROuput.csv" file used for comparing the R results with PMML Evaluation engine results

# Load Original "imports" dataset from "randomForest" package
data(imports85)
# Omit rows with missing values
importsOriginal = na.omit(imports85)

# Converting Ordered factor to normal factor
importsOriginal$numOfCylinders<-factor(importsOriginal$numOfCylinders, ordered = FALSE)

# Apply model to entire dataset and write the results in a csv file
importsEntirePrediction<- predict(importsModel ,importsOriginal)
importsEntirePrediction

# Save predicted value in a data frame
result = data.frame(importsEntirePrediction)
names(result) = c("Predicted_price")

# Write the results in a CSV file
write.csv(result,"ROutput.csv",quote=F)

