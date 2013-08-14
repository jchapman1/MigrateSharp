using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;

namespace EditorNET.VSIX.Intellisense
{
    internal static class EditorNET.VSIX.IntellisenseClassificationDefinition
    {
        /// <summary>
        /// Defines the "EditorNET.VSIX.Intellisense" classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("EditorNET.VSIX.Intellisense")]
        internal static ClassificationTypeDefinition EditorNET.VSIX.IntellisenseType = null;
    }
}
