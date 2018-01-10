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
# install.packages("survival")

# Load below packages
library(pmml)
library(survival)

# Here we directly load the ovarian dataset installed with the "survival" package.
data(ovarian)

# Code below demonstrates loading the same dataset from a CSV file shipped with our installer.
# Please check installed samples (Data) location to set actual working directory 
# Uncomment below lines and comment out the code to read data from package.
# setwd("C:/actual_data_location")
# ovarian= read.csv("Ovarian.csv")

# Divide dataset for training and test
trainData=ovarian[1:20,]
testData=ovarian[19:26,]

# Applying Cox Regression Model to predict Survival
ovarian_Cox = coxph(Surv(futime,fustat)~age+resid.ds+rx+ecog.ps, trainData)
summary(ovarian_Cox)

# Calculate Survival fit of the model
survfit(ovarian_Cox, trainData)
plot(survfit(ovarian_Cox))  

# Display the predicted results
# Predict "Survival" column for test data set
ovarianTestPrediction = predict(ovarian_Cox, type = "expected",testData)
# Display predicted values
ovarianTestPrediction 



# The code below is used for evaluation purpose. 
# The model is applied for original ovarian data set and predicted results are saved in "ROutput.csv"
# "ROutput.csv" file used for comparing the R results with PMML Evaluation engine results

# Load Original "ovarian" dataset from "survival" package
data(ovarian)

#Renaming the columns
names(ovarian) <-c("futime","fustat","age","resid_ds","rx","ecog_ps")

# Applying Cox Regression Model to predict Survival
ovarian_Cox_Entire = coxph(Surv(futime,fustat)~age+resid_ds+rx+ecog_ps, ovarian)
summary(ovarian_Cox_Entire)

# Applying Cox Regression model to entire dataset and save the results in a CSV file
ovarianEntirePrediction = predict(ovarian_Cox_Entire, type = "expected", ovarian)

# PMML generation
pmmlFile<-pmml(ovarian_Cox_Entire, data=ovarian)
write(toString(pmmlFile), file="Ovarian.pmml")
saveXML(pmmlFile, file="Ovarian.pmml")

# Save predicted value in a data frame
result = data.frame(ovarianEntirePrediction)
names(result) = c("Predicted_Survival")

# Write the results in a CSV file
write.csv(result,"ROutput.csv",quote=F)

