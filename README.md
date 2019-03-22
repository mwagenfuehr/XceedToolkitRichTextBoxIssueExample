# Example for an Issue in the Xceed WPF-Toolkit

This is just an example project for an Issue that is occuring in the Xceed WPF-Toolkit

## The Issue

The problem is, that with the `RtfFormatter` (the default Formatter used for `RichTextBox.TextFormatter`) you'll get a lot of `System.FormatException`s. First, when initializing the Control and after that for **every** **KEYSTROKE**. This is not only annoying when developing and testing the Application, but it also slowing down the Application enormously!  
Just think of writing a text of 200 words and with every keystroke an Exception will be thrown in the backend (... fetching the Stacktrace and whatnot). Even with the Diagnostic Tools inside of Visual Studio you're able to see, how many resources a simple program will need.  

... and this:
[!alt text](https://github.com/mwagenfuehr/XceedToolkitRichTextBoxIssueExample/blob/master/OutputChaos.PNG "Output of a simple "Hello my name is"")  
  
  
To further analyze the Exception, be sure to enable the needed Exception inside the `Exception Settings`:
[!alt text](https://github.com/mwagenfuehr/XceedToolkitRichTextBoxIssueExample/blob/master/ExceptionSettings.PNG "The needed Exception Settings to analyze this problem")