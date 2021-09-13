You can run this application with Visual Studio 2019. It needs basic setup.
The application has also covered tests which can also be run from the wizard in visual studio.

I have written this drawing considering the following points,
1) Easy to maintain and change. Eg if you want to change the canvas from empty to dotted you can just change the Constant once. (No need to search other places in code). Similarly, you can change canvas borders, drawing pen easily from constants.
2) Simple for reading and understanding with minimum required details.
3) Exception handling only for necessary stuff otherwise we have handled the invalid scenarios to report gracefully eg ignoring the processing.
4) Followed most of the principles of clean code while writing the functions, classes, interfaces. Still it can be improved with pair programming.
5) Logging has not added but we can add that later point of time (log4net). This we can add for debug, info, error log for troubleshooting’s. This can also use for tracing and auditing.
6) If we want to extend the application with new command its easy with adding new classes for that command without changing the existing classes.
7) Currently the logic written in factories is manual for resolving the parsers and processors but we can use IOC later. When we use IOC then we can get remove the factory classes from code eg. CommandParserFactory, CommandProcessorFactory as IOC will be able to help to resolve the specific instance.
8) The validations can be increased easily by creating new validation rule and then configuring in validation factory.
9) The logic of command parsing, processing, validating is clearly separated from each other.
10) We can extend the program for localizing the messages properly.

Tests:
1)	Added unit test to covered all components individually eg CommandParsers, CommandProcessors
2)	The integration test has added for running all sample commands given in problem sequentially and confirm that it produces same output which is provided in problem.
Scope of improvements:
Point 7 and 10 above.
This application is prepared to print the output on console but can be easily switched be used at other places due to its flexibility.
