﻿// See https://aka.ms/new-console-template for more information

using Syncfusion.HtmlConverter;
using Syncfusion.Pdf;

//Initialize the HTML to PDF converter with Blink rendering engine.
HtmlToPdfConverter htmlConverter = new HtmlToPdfConverter(HtmlRenderingEngine.Blink);

//Create blink converter settings. 
BlinkConverterSettings blinkConverterSettings = new BlinkConverterSettings();

//Set print media type.
blinkConverterSettings.MediaType = MediaType.Screen;

//Assign Blink converter settings to HTML converter.
htmlConverter.ConverterSettings = blinkConverterSettings;

//Convert URL to PDF document. 
PdfDocument document = htmlConverter.Convert("https://www.google.com");

//Create file stream. 
FileStream fileStream = new FileStream(Path.GetFullPath("../../../Sample.pdf"), FileMode.CreateNew, FileAccess.ReadWrite);

//Save and close the PDF document.
document.Save(fileStream);
document.Close(true);