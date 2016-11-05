using System;
using System.Configuration;
using System.Xml;

namespace AppConfiguration
{
    public class CollectionSection : ConfigurationSection
    {
        [ConfigurationProperty("collection", IsDefaultCollection = false)]
        [ConfigurationCollection(typeof(CollectionConfig), AddItemName = "add")]
        public CollectionConfig Collection
        {
            get
            {
                return (CollectionConfig)this["collection"];
            }

            set
            {
                this["collection"] = value;
            }
        }
    }

    public class Parent : ConfigurationElement
    {
        [ConfigurationProperty("name", IsRequired = true)]
        public string Name
        {
            get
            {
                return (string)this["name"];
            }

            set
            {
                this["name"] = value;
            }
        }

        [ConfigurationProperty("type", IsRequired = true)]
        public string Type
        {
            get
            {
                return (string)this["type"];
            }

            set
            {
                this["type"] = value;
            }
        }

        public void ProxyDeserializeElement(XmlReader reader, bool serializeCollectionKey)
        {
            DeserializeElement(reader, serializeCollectionKey);
        }
    }

    public class One : Parent
    {
        [ConfigurationProperty("p1")]
        public string P1
        {
            get
            {
                return (string)this["p1"];
            }

            set
            {
                this["p1"] = value;
            }
        }
    }

    public class Two : Parent
    {
        [ConfigurationProperty("p2")]
        public string P2
        {
            get
            {
                return (string)this["p2"];
            }

            set
            {
                this["p2"] = value;
            }
        }
    }

    public class Proxy : ConfigurationElement
    {
        private Parent _parent;

        public Parent Parent => _parent;

        public Parent Instance => _parent;

        protected override void DeserializeElement(XmlReader reader, bool serializeCollectionKey)
        {
            string type = reader.GetAttribute("type");
            switch (type)
            {
                case "one":
                    _parent = new One();
                    break;
                case "two":
                    _parent = new Two();
                    break;
                default:
                    throw new ArgumentException($"Invalid type: {type}");
            }

            _parent.ProxyDeserializeElement(reader, serializeCollectionKey);
        }
    }

    public class CollectionConfig : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new Proxy();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((Proxy)element).Parent.Name;
        }

        public Parent this[int index]
        {
            get
            {
                return ((Proxy)BaseGet(index)).Parent;
            }

            set
            {
                if (BaseGet(index) != null)
                {
                    BaseRemoveAt(index);
                }

                BaseAdd(index, value);
            }
        }
    }
}