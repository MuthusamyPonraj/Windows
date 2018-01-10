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
# install.packages("e1071")
# install.packages("pmml")
# install.packages("gmodels")
# install.packages("randomForest")
# install.packages("ROCR")
# install.packages("caret")

# Load below packages
library(e1071)
library(pmml) 
library(gmodels)
library(randomForest) # This package is specifically loaded for imports85 dataset shipped within it.
library(ROCR)
library(caret)

# Here we directly load the imports85 dataset installed with the "randomForest" package.
data(imports85)
# Omit rows with missing values
imports <- na.omit(imports85)

# Code below demonstrates loading the same dataset from a CSV file shipped with our installer.
# Please check installed samples (Data) location to set actual working directory 
# Uncomment below lines and comment out the code to read data from CSV file.
# setwd("C:/actual_data_location")
# imports<- read.csv("Imports.csv")

# Randomizing data
imports<-imports[sample(nrow(imports)),]

# Divide dataset for training and test
trainData <- imports[1:124, ]
testData  <- imports[125:155, ]

# Set predicted field in formula
formula = formula(fuelType ~ .)

# Create model for training set using naiveBayes
importsTrainingModel = naiveBayes(formula, trainData, threshold = 0)

# Display the predicted results and create cross table to check on accuracy
# Predict "fuelType" column for test data set
importsTestPrediction <- predict(importsTrainingModel, testData)
# Display predicted values
importsTestPrediction

# Create cross table to check on accuracy.

CrossTable(importsTestPrediction, testData$fuelType,
           prop.chisq = FALSE, prop.t = FALSE, prop.r = FALSE,
           dnn = c('predicted', 'actual'))


# PMML generation 
saveXML(pmml(importsTrainingModel, predictedField = "fuelType"), "Imports.pmml")

# The code below is used for evaluation purpose. 
# The model is applied for original imports data set and predicted results are saved in "ROuput.csv"
# "ROuput.csv" file used for comparing the R results with PMML Evaluation engine results

# Load Original "imports" dataset from "randomForest" package
data(imports85)
# Omit rows with missing values
importsOriginal = na.omit(imports85)

# Applying Naive Bayes model to entire dataset and save the results in a CSV file
classes = predict(importsTrainingModel, newdata = importsOriginal, threshold = 0, type = "class")
probabilities = predict(importsTrainingModel, newdata = importsOriginal, threshold = 0, type = "raw")

# Save predicted value in a data frame
writeOutput = function(classes, probabilities, file)
{
	result = NULL
	if(is.null(probabilities))
	{
		result = data.frame(classes)
		names(result) = c("fuelType")
	} 
	else
	{
		result = data.frame(classes, probabilities)
		names(result) = c("fuelType", "DieselFuelTypeProbability","GasFuelTypeProbability")
	}
	write.csv(result, file, quote=F)
}

# Write the results in a CSV file
writeOutput(classes, probabilities, "ROutput.csv")