﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyMCERTE {
    public class TinyEditorConfigurationResult {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Sitecore.Shell.Controls.RichTextEditor.EditorConfigurationResult" /> class.
        /// </summary>
        public TinyEditorConfigurationResult() {
        }

        /// <summary>Gets or sets the Toolbar configuration section.</summary>
        /// <value>The toolbar configuration section.</value>
        public string EditorToolbar { get; set; }

        /// <summary>Gets or sets the Plugins configuration section.</summary>
        /// <value>The plugins configuration section.</value>
        public string EditorPlugins { get; set; }

        /// <summary>Gets or sets the Callback configuration section.</summary>
        /// <value>The callback configuration section.</value>
        public string EditorInitCallback { get; set; }

        /// <summary>Gets or sets the EditorMenubar config element.</summary>
        /// <value>The Editor Menubar section.</value>
        public string EditorMenubar { get; set; }

        /// <summary>Gets or sets the EditorBranding config element.</summary>
        /// <value>The Editor Branding section.</value>
        public string EditorBranding { get; set; }

        /// <summary>Gets or sets the CSSPath config element.</summary>
        /// <value>The CSS file to apply to the editor's content.</value>
        public string CSSPath { get; set; }
    }
}
