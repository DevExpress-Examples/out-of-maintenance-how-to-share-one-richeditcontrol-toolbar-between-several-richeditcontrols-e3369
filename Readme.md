<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128611252/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3369)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))
<!-- default file list end -->
# How to share one RichEditControl toolbar between several RichEditControls


<p>Let us assume that we have created a simple rich text editor with a toolbar interface (see <a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument5807"><u>How to: Create a Simple Word Processor with Bar Menu</u></a> and <a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument5812"><u>How to: Create a Simple Word Processor with Ribbon Menu</u></a> help sections). Now, if you want to reuse RichEditControl UI for several RichEditControls on the form, do the following:</p><p>1) Detach the original RichEditControl from the <strong>RichEditBarController.RichEditControl</strong> property at design time in the VS Property Grid.<br />
2) Handle the <strong>RichEditControl.Enter</strong> event for all RichEditControls on the form and assign the source RichEditControl to the <strong>RichEditBarController.RichEditControl</strong> property.</p><p><strong>NOTE:</strong> If you want each RichEditControl to have its own UI, you can create a separate UserControl with RichEditControl and its UI. Then, just add a required number of these UserControl instances to the form.</p>

<br/>


