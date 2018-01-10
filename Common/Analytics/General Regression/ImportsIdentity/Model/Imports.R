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
# install.packages("pmml")
# install.packages("gmodels")
# install.packages("randomForest")
# install.packages("e1071")

# Load below packages
library(pmml)
library(gmodels)
library(randomForest) # This package is specifically loaded for imports85 dataset shipped within it.
library(e1071)

# Here we directly load the audit dataset installed with the "randomForest" package.
data(imports85)
# Omit rows with missing values
imports = na.omit(imports85)

# Code below demonstrates loading the same dataset from a CSV file shipped with our installer.
# Please check installed samples (Data) location to set actual working directory 
# Uncomment below lines and comment out the code to read data from CSV file.
# setwd("C:/actual_data_location")
# imports= read.csv("Imports.csv")

# Randomizing data
imports<-imports[sample(nrow(imports)),]

# Divide dataset for training and test
trainData<-imports[1:128,]
testData<-imports[129:159,]

# Applying the General Regression Model function into # Applying General Regression Model - identity function to predict censlink functions
importsFormula = formula(price~ symboling+normalizedLosses+	fuelType+aspiration+numOfDoors+bodyStyle+driveWheels+wheelBase+length+width+height+curbWeight+engineSize+bore+stroke+compressionRatio+horsepower+peakRpm+cityMpg+highwayMpg)
imports_GLM = glm(importsFormula , trainData, family = gaussian(link="identity"))
summary(imports_GLM)

# Display the predicted results 
# Predict "price" column probability for test data set
importsTestProbabilities = predict(imports_GLM,type = "response",testData)
# Display predicted probabilities
importsTestProbabilities

# PMML generation
pmmlFile<-pmml(imports_GLM,data=trainData)
write(toString(pmmlFile),file="Imports.pmml")
saveXML(pmmlFile,file="Imports.pmml")



# The code below is used for evaluation purpose. 
# The model is applied for original imports data set and predicted results are saved in "ROutput.csv"
# "ROutput.csv" file used for comparing the R results with PMML Evaluation engine results

# Load Original "imports" dataset from "randomForest" package
data(imports85)
# Omit rows with missing values
importsOriginal = na.omit(imports85)

# Applying General Regression model to entire dataset and save the results in a CSV file
importsEntireProbabilities = predict(imports_GLM, type = "response",importsOriginal)

# Save predicted value in a data frame
result = data.frame(importsEntireProbabilities)
names(result) = c("Predicted_price")

# Write the results in a CSV file
write.csv(result,"ROutput.csv",quote=F)



