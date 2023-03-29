# ILogger Interface Example

## For .NetFramework
## Log Files Created Daily
## LogRootFolder/yyyy/MM/dd/log_file_name.log
e.g. D:/2022/03/15/logfile_20220315.log

--------

1. Create LoggerOptions Class
2. Create LoggerProvider Class
3. Create Logger Class
4. Add Config Items To App.config

--------

This shows how to implement ILogger in .NetFramework Environment.
It also shows how to avoid exceptions when writing logs in multi-threaded environment
Last but not least, it shows how to separate logs into individual files according to some IDs

--------

Refer to the Mainform button event handlers to see how to use it.

