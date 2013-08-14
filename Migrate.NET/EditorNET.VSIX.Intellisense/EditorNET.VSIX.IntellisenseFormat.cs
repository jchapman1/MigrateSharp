using System.ComponentModel.Composition;
using System.Windows.Media;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;

namespace EditorNET.VSIX.Intellisense
{
    #region Format definition
    /// <summary>
    /// Defines an editor format for the EditorNET.VSIX.Intellisense type that has a purple background
    /// and is underlined.
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "EditorNET.VSIX.Intellisense")]
    [Name("EditorNET.VSIX.Intellisense")]
    [UserVisible(true)] //this should be visible to the end user
    [Order(Before = Priority.Default)] //set the priority to be after the default classifiers
    internal sealed class EditorNET.VSIX.IntellisenseFormat : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "EditorNET.VSIX.Intellisense" classification type
        /// </summary>
        public EditorNET.VSIX.IntellisenseFormat()
        {
            this.DisplayName = "EditorNET.VSIX.Intellisense"; //human readable version of the name
            this.BackgroundColor = Colors.BlueViolet;
            this.TextDecorations = System.Windows.TextDecorations.Underline;
        }
    }
    #endregion //Format definition
}
