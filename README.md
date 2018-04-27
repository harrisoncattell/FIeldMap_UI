# FieldMap_UI

Created by Harrison Cattell, 2018

##### Introduction
FieldMap is an analysis and mapping software to provide visual provide analysis and visual representation of sampled soil data. The software uses a bicubic interpolation algorithm to increase the sample rate of the data.

##### Important Informatation
Before using this software, make sure you have the MATLAB Runtime is installed. You will find this in the setup file under 'FieldMap Installer. 
If you try to run the program without installing MATLAB Runtime you will run into an error message stating 'FieldMap has threw an exception'. To fix this close the program and install the Runtime from this file listed above.
To install, click 'FieldMap Setup' and run through the setup. When finished, the application should open up

##### Data Requirements
To use the mapping software, you need a data set that is in the form of a matrix in text file.
Please note that the default seperator for each data element is a space (' '). If any other seperator is used in the text file the software will produce an error

There is some sample data that can be used for testing the application, it is named 'Sample_Data'