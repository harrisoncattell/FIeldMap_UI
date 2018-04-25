# FieldMap_UI

Created by Harrison Cattell, 2018

##### Introduction
FieldMap is an analysis and mapping software to provide visual provide analysis and visual representation of sampled soil data. The software uses a bicubic interpolation algorithm to increase the sample rate of the data.

##### Important Informatation
Before using this software, make sure you have the [MATLAB Runtime installed] (https://uk.mathworks.com/products/compiler/matlab-runtime.html). This software uses a MATLAB function set exported as a libray for C#, even though MATLAB isn't required for the target machine, the Runtime is required to exectute the code.

##### Data Requirements
To use the mapping software, you need a data set that is in the form of a matrix in text file.
Please note that the default seperator for each data element is a space (' '). If any other seperator is used in the text file the software will produce an error