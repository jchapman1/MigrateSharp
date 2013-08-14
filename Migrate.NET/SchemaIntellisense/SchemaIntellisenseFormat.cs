using System.ComponentModel.Composition;
using System.Windows.Media;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;

namespace SchemaIntellisense
{
    #region Format definition
    /// <summary>
    /// Defines an editor format for the SchemaIntellisense type that has a purple background
    /// and is underlined.
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "SchemaIntellisense")]
    [Name("SchemaIntellisense")]
    [UserVisible(true)] //this should be visible to the end user
    [Order(Before = Priority.Default)] //set the priority to be after the default classifiers
    internal sealed class SchemaIntellisenseFormat : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "SchemaIntellisense" classification type
        /// </summary>
        public SchemaIntellisenseFormat()
        {
            this.DisplayName = "SchemaIntellisense"; //human readable version of the name
            this.BackgroundColor = Colors.BlueViolet;
            this.TextDecorations = System.Windows.TextDecorations.Underline;
        }
    }
    #endregion //Format definition
}
