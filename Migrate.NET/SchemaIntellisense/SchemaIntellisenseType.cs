using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;

namespace SchemaIntellisense
{
    internal static class SchemaIntellisenseClassificationDefinition
    {
        /// <summary>
        /// Defines the "SchemaIntellisense" classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("SchemaIntellisense")]
        internal static ClassificationTypeDefinition SchemaIntellisenseType = null;
    }
}
