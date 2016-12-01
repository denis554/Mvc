//--------------------------------------------------------------------------------------------------
// <auto-generated>
//
//     This code was generated by code generator tool.
//
//     To customize the code use your own partial class. For more info about how to use and customize
//     the generated code see the documentation at http://docs.kentico.com.
//
// </auto-generated>
//--------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

using CMS;
using CMS.Base;
using CMS.Helpers;
using CMS.DataEngine;
using CMS.DocumentEngine.Types.DancingGoatMvc;
using CMS.DocumentEngine;

[assembly: RegisterDocumentType(Contact.CLASS_NAME, typeof(Contact))]

namespace CMS.DocumentEngine.Types.DancingGoatMvc
{
    /// <summary>
    /// Represents a content item of type Contact.
    /// </summary>
    public partial class Contact : TreeNode
    {
        #region "Constants and variables"

        /// <summary>
        /// The name of the data class.
        /// </summary>
        public const string CLASS_NAME = "DancingGoatMvc.Contact";


        /// <summary>
        /// The instance of the class that provides extended API for working with Contact fields.
        /// </summary>
        private readonly ContactFields mFields;

        #endregion


        #region "Properties"

        /// <summary>
        /// ContactID.
        /// </summary>
        [DatabaseIDField]
        public int ContactID
        {
            get
            {
                return ValidationHelper.GetInteger(GetValue("ContactID"), 0);
            }
            set
            {
                SetValue("ContactID", value);
            }
        }


        /// <summary>
        /// Company name.
        /// </summary>
        [DatabaseField]
        public string ContactName
        {
            get
            {
                return ValidationHelper.GetString(GetValue("ContactName"), "");
            }
            set
            {
                SetValue("ContactName", value);
            }
        }


        /// <summary>
        /// Street.
        /// </summary>
        [DatabaseField]
        public string ContactStreet
        {
            get
            {
                return ValidationHelper.GetString(GetValue("ContactStreet"), "");
            }
            set
            {
                SetValue("ContactStreet", value);
            }
        }


        /// <summary>
        /// City.
        /// </summary>
        [DatabaseField]
        public string ContactCity
        {
            get
            {
                return ValidationHelper.GetString(GetValue("ContactCity"), "");
            }
            set
            {
                SetValue("ContactCity", value);
            }
        }


        /// <summary>
        /// Country.
        /// </summary>
        [DatabaseField]
        public string ContactCountry
        {
            get
            {
                return ValidationHelper.GetString(GetValue("ContactCountry"), "USA");
            }
            set
            {
                SetValue("ContactCountry", value);
            }
        }


        /// <summary>
        /// Zip code.
        /// </summary>
        [DatabaseField]
        public string ContactZipCode
        {
            get
            {
                return ValidationHelper.GetString(GetValue("ContactZipCode"), "");
            }
            set
            {
                SetValue("ContactZipCode", value);
            }
        }


        /// <summary>
        /// Phone.
        /// </summary>
        [DatabaseField]
        public string ContactPhone
        {
            get
            {
                return ValidationHelper.GetString(GetValue("ContactPhone"), "");
            }
            set
            {
                SetValue("ContactPhone", value);
            }
        }


        /// <summary>
        /// Email.
        /// </summary>
        [DatabaseField]
        public string ContactEmail
        {
            get
            {
                return ValidationHelper.GetString(GetValue("ContactEmail"), "");
            }
            set
            {
                SetValue("ContactEmail", value);
            }
        }


        /// <summary>
        /// Gets an object that provides extended API for working with Contact fields.
        /// </summary>
        [RegisterProperty]
        public ContactFields Fields
        {
            get
            {
                return mFields;
            }
        }


        /// <summary>
        /// Provides extended API for working with Contact fields.
        /// </summary>
        [RegisterAllProperties]
        public partial class ContactFields : AbstractHierarchicalObject<ContactFields>
        {
            /// <summary>
            /// The content item of type Contact that is a target of the extended API.
            /// </summary>
            private readonly Contact mInstance;


            /// <summary>
            /// Initializes a new instance of the <see cref="ContactFields" /> class with the specified content item of type Contact.
            /// </summary>
            /// <param name="instance">The content item of type Contact that is a target of the extended API.</param>
            public ContactFields(Contact instance)
            {
                mInstance = instance;
            }


            /// <summary>
            /// ContactID.
            /// </summary>
            public int ID
            {
                get
                {
                    return mInstance.ContactID;
                }
                set
                {
                    mInstance.ContactID = value;
                }
            }


            /// <summary>
            /// Company name.
            /// </summary>
            public string Name
            {
                get
                {
                    return mInstance.ContactName;
                }
                set
                {
                    mInstance.ContactName = value;
                }
            }


            /// <summary>
            /// Street.
            /// </summary>
            public string Street
            {
                get
                {
                    return mInstance.ContactStreet;
                }
                set
                {
                    mInstance.ContactStreet = value;
                }
            }


            /// <summary>
            /// City.
            /// </summary>
            public string City
            {
                get
                {
                    return mInstance.ContactCity;
                }
                set
                {
                    mInstance.ContactCity = value;
                }
            }


            /// <summary>
            /// Country.
            /// </summary>
            public string Country
            {
                get
                {
                    return mInstance.ContactCountry;
                }
                set
                {
                    mInstance.ContactCountry = value;
                }
            }


            /// <summary>
            /// Zip code.
            /// </summary>
            public string ZipCode
            {
                get
                {
                    return mInstance.ContactZipCode;
                }
                set
                {
                    mInstance.ContactZipCode = value;
                }
            }


            /// <summary>
            /// Phone.
            /// </summary>
            public string Phone
            {
                get
                {
                    return mInstance.ContactPhone;
                }
                set
                {
                    mInstance.ContactPhone = value;
                }
            }


            /// <summary>
            /// Email.
            /// </summary>
            public string Email
            {
                get
                {
                    return mInstance.ContactEmail;
                }
                set
                {
                    mInstance.ContactEmail = value;
                }
            }
        }

        #endregion


        #region "Constructors"

        /// <summary>
        /// Initializes a new instance of the <see cref="Contact" /> class.
        /// </summary>
        public Contact() : base(CLASS_NAME)
        {
            mFields = new ContactFields(this);
        }

        #endregion
    }
}