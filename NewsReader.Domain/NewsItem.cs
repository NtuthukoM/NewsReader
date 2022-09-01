namespace NewsReader.Domain
{

        // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
        /// <remarks/>
        //[System.SerializableAttribute()]
        //[System.ComponentModel.DesignerCategoryAttribute("code")]
        //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public class NewsItem
    {

            private string titleField;

            private string descriptionField = "";

            private string linkField;

            private string pubDateField;

            /// <remarks/>
            public string title
            {
                get
                {
                    return this.titleField;
                }
                set
                {
                    this.titleField = value;
                }
            }

            /// <remarks/>
            public string description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            public string link
            {
                get
                {
                    return this.linkField;
                }
                set
                {
                    this.linkField = value;
                }
            }

            /// <remarks/>
            public string pubDate
            {
                get
                {
                    return this.pubDateField;
                }
                set
                {
                    this.pubDateField = value;
                }
            }

        }

}