// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Paper
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The paper doc export object</para>
    /// </summary>
    /// <seealso cref="Global::Dropbox.Api.Paper.RefPaperDoc" />
    public class PaperDocExport : RefPaperDoc
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<PaperDocExport> Encoder = new PaperDocExportEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<PaperDocExport> Decoder = new PaperDocExportDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="PaperDocExport" /> class.</para>
        /// </summary>
        /// <param name="docId">The doc id</param>
        /// <param name="exportFormat">The export format</param>
        public PaperDocExport(string docId,
                              ExportFormat exportFormat)
            : base(docId)
        {
            if (exportFormat == null)
            {
                throw new sys.ArgumentNullException("exportFormat");
            }

            this.ExportFormat = exportFormat;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="PaperDocExport" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public PaperDocExport()
        {
        }

        /// <summary>
        /// <para>Gets the export format of the paper doc export</para>
        /// </summary>
        public ExportFormat ExportFormat { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="PaperDocExport" />.</para>
        /// </summary>
        private class PaperDocExportEncoder : enc.StructEncoder<PaperDocExport>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(PaperDocExport value, enc.IJsonWriter writer)
            {
                WriteProperty("doc_id", value.DocId, writer, enc.StringEncoder.Instance);
                WriteProperty("export_format", value.ExportFormat, writer, global::Dropbox.Api.Paper.ExportFormat.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="PaperDocExport" />.</para>
        /// </summary>
        private class PaperDocExportDecoder : enc.StructDecoder<PaperDocExport>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="PaperDocExport" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override PaperDocExport Create()
            {
                return new PaperDocExport();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(PaperDocExport value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "doc_id":
                        value.DocId = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "export_format":
                        value.ExportFormat = global::Dropbox.Api.Paper.ExportFormat.Decoder.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
