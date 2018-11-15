<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/S92027/Form1.cs) (VB: [Form1.vb](./VB/S92027/Form1.vb))
* [MySimpleButton.cs](./CS/S92027/MySimpleButton.cs) (VB: [MySimpleButton.vb](./VB/S92027/MySimpleButton.vb))
* [Program.cs](./CS/S92027/Program.cs) (VB: [Program.vb](./VB/S92027/Program.vb))
<!-- default file list end -->
# How to implement a "Shortcut" functionality for the SimpleButton


<p>The SimpleButton doesn't support shortcuts. In simple situations, it's quite enough to use the access key as described in the <a href="http://msdn.microsoft.com/en-us/library/az5a73z1.aspx">How to: Create Access Keys for Windows Forms Controls</a> article. If you need to handle any specific key combination, you can utilize the functionality provided by the XtraBars. All you need is to put the BarManager onto the Form and add BarButtonItems to handle shortcuts and invoke an associated method.</p>

<br/>


