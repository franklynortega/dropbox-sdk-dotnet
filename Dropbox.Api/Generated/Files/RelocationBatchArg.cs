// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Files
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The relocation batch arg object</para>
    /// </summary>
    public class RelocationBatchArg
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<RelocationBatchArg> Encoder = new RelocationBatchArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<RelocationBatchArg> Decoder = new RelocationBatchArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="RelocationBatchArg" />
        /// class.</para>
        /// </summary>
        /// <param name="entries">List of entries to be moved or copied. Each entry is <see
        /// cref="RelocationPath" />.</param>
        /// <param name="allowSharedFolder">If true, <see
        /// cref="Dropbox.Api.Files.Routes.FilesUserRoutes.CopyBatchAsync" /> will copy
        /// contents in shared folder, otherwise <see
        /// cref="Dropbox.Api.Files.RelocationError.CantCopySharedFolder" /> will be returned
        /// if <see cref="Dropbox.Api.Files.RelocationPath.FromPath" /> contains shared folder.
        /// This field is always true for <see
        /// cref="Dropbox.Api.Files.Routes.FilesUserRoutes.MoveBatchAsync" />.</param>
        /// <param name="autorename">If there's a conflict with any file, have the Dropbox
        /// server try to autorename that file to avoid the conflict.</param>
        public RelocationBatchArg(col.IEnumerable<RelocationPath> entries,
                                  bool allowSharedFolder = false,
                                  bool autorename = false)
        {
            var entriesList = enc.Util.ToList(entries);

            if (entries == null)
            {
                throw new sys.ArgumentNullException("entries");
            }

            this.Entries = entriesList;
            this.AllowSharedFolder = allowSharedFolder;
            this.Autorename = autorename;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="RelocationBatchArg" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public RelocationBatchArg()
        {
            this.AllowSharedFolder = false;
            this.Autorename = false;
        }

        /// <summary>
        /// <para>List of entries to be moved or copied. Each entry is <see
        /// cref="RelocationPath" />.</para>
        /// </summary>
        public col.IList<RelocationPath> Entries { get; protected set; }

        /// <summary>
        /// <para>If true, <see cref="Dropbox.Api.Files.Routes.FilesUserRoutes.CopyBatchAsync"
        /// /> will copy contents in shared folder, otherwise <see
        /// cref="Dropbox.Api.Files.RelocationError.CantCopySharedFolder" /> will be returned
        /// if <see cref="Dropbox.Api.Files.RelocationPath.FromPath" /> contains shared folder.
        /// This field is always true for <see
        /// cref="Dropbox.Api.Files.Routes.FilesUserRoutes.MoveBatchAsync" />.</para>
        /// </summary>
        public bool AllowSharedFolder { get; protected set; }

        /// <summary>
        /// <para>If there's a conflict with any file, have the Dropbox server try to
        /// autorename that file to avoid the conflict.</para>
        /// </summary>
        public bool Autorename { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="RelocationBatchArg" />.</para>
        /// </summary>
        private class RelocationBatchArgEncoder : enc.StructEncoder<RelocationBatchArg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(RelocationBatchArg value, enc.IJsonWriter writer)
            {
                WriteListProperty("entries", value.Entries, writer, global::Dropbox.Api.Files.RelocationPath.Encoder);
                WriteProperty("allow_shared_folder", value.AllowSharedFolder, writer, enc.BooleanEncoder.Instance);
                WriteProperty("autorename", value.Autorename, writer, enc.BooleanEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="RelocationBatchArg" />.</para>
        /// </summary>
        private class RelocationBatchArgDecoder : enc.StructDecoder<RelocationBatchArg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="RelocationBatchArg" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override RelocationBatchArg Create()
            {
                return new RelocationBatchArg();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(RelocationBatchArg value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "entries":
                        value.Entries = ReadList<RelocationPath>(reader, global::Dropbox.Api.Files.RelocationPath.Decoder);
                        break;
                    case "allow_shared_folder":
                        value.AllowSharedFolder = enc.BooleanDecoder.Instance.Decode(reader);
                        break;
                    case "autorename":
                        value.Autorename = enc.BooleanDecoder.Instance.Decode(reader);
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
