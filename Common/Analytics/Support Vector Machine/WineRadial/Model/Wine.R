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
# install.packages("kernlab")
# install.packages("pmml") 
# install.packages("gmodels") 
# install.packages("rattle") 

# Load below packages
library(kernlab)
library(pmml)
library(rattle) # This package is specifically loaded for wine dataset shipped within it.
library(gmodels)

# Here we directly load the wine dataset installed with the "rattle" package.
data(wine)
# Omit rows with missing values
wine <- na.omit(wine)

# Code below demonstrates loading the same dataset from a CSV file shipped with our installer.
# Please check installed samples (Data) location to set actual working directory 
# Uncomment below lines and comment out the code to read data from CSV file.
# setwd("C:/actual_data_location")
# wine <- read.csv("Wine.csv")

# Considering integer variable as factor
wine[, "Type"]=as.factor(wine[, "Type"])

# Randomizing data
wine<- wine[sample(nrow(wine)),]

# Divide dataset for training and test
trainData<-wine[1:148,]
testData<-wine[149:178,]

# Applying Support vector Machine Function using Radial basis kernel- "rbfdot"
wine_SVM<-ksvm(Type~.,data=trainData,kernel="rbfdot")
wine_SVM

# Display the predicted results and create cross table to check on accuracy
# Predict "Type" column for test data set
wineTestPrediction<-predict(wine_SVM,testData)
# Display predicted values
wineTestPrediction

# Create cross table to check on accuracy.
CrossTable(testData$Type,wineTestPrediction,prop.chisq = FALSE, prop.t = FALSE, prop.r = FALSE,
           dnn = c('actual', 'predicted'))


# PMML generation
pmmlFile<-pmml(wine_SVM,data=trainData)
write(toString(pmmlFile),file="Wine.pmml")
saveXML(pmmlFile,file="Wine.pmml")

# The code below is used for evaluation purpose. 
# The model is applied for original Wine data set and predicted results are saved in "ROuput.csv"
# "ROuput.csv" file used for comparing the R results with PMML Evaluation engine results

# Load Original "wine" dataset from "rattle" package
data(wine)
# Omit rows with missing values
wineOriginal <- na.omit(wine)

# Considering integer variable as factor
wineOriginal[, "Type"]=as.factor(wineOriginal[, "Type"])

# Applying Support vector Machine model to entire dataset and save the results in a CSV file
wineEntirePrediction<-predict(wine_SVM,wineOriginal)
wineEntirePrediction

# Save predicted value in a data frame
result = data.frame(wineEntirePrediction)
names(result) = c("Predicted_Type")

# Write the results in a CSV file
write.csv(result,"ROutput.csv",quote=F)
