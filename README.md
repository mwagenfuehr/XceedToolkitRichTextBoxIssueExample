# Example for an Issue in the Xceed WPF-Toolkit

This is just an example project for an Issue that is occuring in the Xceed WPF-Toolkit

## The Issue

The problem is, that with the `RtfFormatter` (the default Formatter used for `RichTextBox.TextFormatter`) you'll get a lot of `System.FormatException`s. First, when initializing the Control and after that for **every** **KEYSTROKE**. This is not only annoying when developing and testing the Application, but it also slowing down the Application enormously!  
Just think of writing a text of 200 words and with every keystroke an Exception will be thrown in the backend (... fetching the Stacktrace and whatnot). Even with the Diagnostic Tools inside of Visual Studio you're able to see, how many resources a simple program will need.  

... and this:  
![alt text](https://github.com/mwagenfuehr/XceedToolkitRichTextBoxIssueExample/blob/master/OutputChaos.PNG "Output of a simple 'Hello my name is'")  
  
  
To further analyze the Exception, be sure to enable the needed Exception inside the `Exception Settings`:  
![alt text](https://github.com/mwagenfuehr/XceedToolkitRichTextBoxIssueExample/blob/master/ExceptionSettings.PNG "The needed Exception Settings to analyze this problem")
  

## Examples

Here are simple explanations to the given Examples of the Project:

### Example 01

This is a simple program that uses the `RichTextBox` as is. So no modifications or anything are made to any of the Properties.  
  
But you'll notice two things:
1. An exception will be thrown right when the program starts (The Property `RichTextBox.TextFormatter` will be initilized with the default `RtfFormatter`)
2. An exception will be thrown for every keystroke, when typing inside the RichTextBox

### Example 02

This is essentially the same as `Example 01` but I'm explitely setting the `TextFormatter` to an instance of `RtfFormatter`. Nothing changes here, still the same result.

### Example 03

Here I'm setting the `TextFormatter` to an instance of `PlainTextFormatter` with the help of a StaticRessource inside `MainWindow.xaml`.  
Here everything will work fine. No exception will be raised when starting the program or typing something inside the `RichTextBox`. No errors.

### Example 04

Here I'm setting the `TextFormatter` to an instance of `XamlFormatter` inside the Contructor after `InitializeComponent()`.  
This will raise an exception right when the Program starts (because the `TextFormatter` will get it's default value (see `Example 01`)). But after that everything will be alright. No more exceptions when writing text or doing other things.

### Example 05

This is just an example using the default `RichTextBox` that is implemented within WPF. Here you don't have any way to change a `TextFormatter` so I didn't change any property.  
Here you won't get any errors aswell. Initializing and typing are free from Exception.

## Conclusion

From the tests covered in the Examples above, you're able to see that something is wrong with the `RtfFormatter` that is used by default by the `RichTextBox` in the WpfToolkit by Xceed. It'll throw a lot of `System.FormatException`s when initializing and typing. 