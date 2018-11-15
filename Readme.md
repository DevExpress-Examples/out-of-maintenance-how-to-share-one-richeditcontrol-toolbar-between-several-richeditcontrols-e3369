<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))
<!-- default file list end -->
# How to share one RichEditControl toolbar between several RichEditControls


<p>Let us assume that we have created a simple rich text editor with a toolbar interface (see <a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument5807"><u>How to: Create a Simple Word Processor with Bar Menu</u></a> and <a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument5812"><u>How to: Create a Simple Word Processor with Ribbon Menu</u></a> help sections). Now, if you want to reuse RichEditControl UI for several RichEditControls on the form, do the following:</p><p>1) Detach the original RichEditControl from the <strong>RichEditBarController.RichEditControl</strong> property at design time in the VS Property Grid.<br />
2) Handle the <strong>RichEditControl.Enter</strong> event for all RichEditControls on the form and assign the source RichEditControl to the <strong>RichEditBarController.RichEditControl</strong> property.</p><p><strong>NOTE:</strong> If you want each RichEditControl to have its own UI, you can create a separate UserControl with RichEditControl and its UI. Then, just add a required number of these UserControl instances to the form.</p>


<h3>Description</h3>

<p><br />
</p>

<br/>


