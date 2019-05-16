# Order Number Generator
C# Component for creating order number automatically

You can find the component (as .dll file) in "<strong>/OrderNumberGenerator/OrderNumberGenerator/bin/Debug/OrderNumberGenerator.dll</strong>".

Add the component to your project by "Add References" in your Solution Explorer.

<strong>How to use component:</strong><br/>
NumberGenerator generator = new NumberGenerator();<br/>
string orderNumber = generator.GenerateNumber("FT");

The result will be like this: FT-201905-0256353
