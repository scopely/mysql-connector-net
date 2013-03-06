﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("booksModel", "fk_authors_myBooks", "myauthors", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(MySql.Data.Entity.Tests.myauthor), "mybooks", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(MySql.Data.Entity.Tests.mybook), true)]
[assembly: EdmRelationshipAttribute("booksModel", "myeditionsinmybooks", "mybooks", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(MySql.Data.Entity.Tests.mybook), "myeditions", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(MySql.Data.Entity.Tests.myedition))]

#endregion

namespace MySql.Data.Entity.Tests
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class mybooksEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new mybooksEntities object using the connection string found in the 'mybooksEntities' section of the application configuration file.
        /// </summary>
        public mybooksEntities() : base("name=mybooksEntities", "mybooksEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new mybooksEntities object.
        /// </summary>
        public mybooksEntities(string connectionString) : base(connectionString, "mybooksEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new mybooksEntities object.
        /// </summary>
        public mybooksEntities(EntityConnection connection) : base(connection, "mybooksEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<myauthor> myauthors
        {
            get
            {
                if ((_myauthors == null))
                {
                    _myauthors = base.CreateObjectSet<myauthor>("myauthors");
                }
                return _myauthors;
            }
        }
        private ObjectSet<myauthor> _myauthors;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<mybook> mybooks
        {
            get
            {
                if ((_mybooks == null))
                {
                    _mybooks = base.CreateObjectSet<mybook>("mybooks");
                }
                return _mybooks;
            }
        }
        private ObjectSet<mybook> _mybooks;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<myedition> myeditions
        {
            get
            {
                if ((_myeditions == null))
                {
                    _myeditions = base.CreateObjectSet<myedition>("myeditions");
                }
                return _myeditions;
            }
        }
        private ObjectSet<myedition> _myeditions;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the myauthors EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTomyauthors(myauthor myauthor)
        {
            base.AddObject("myauthors", myauthor);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the mybooks EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTomybooks(mybook mybook)
        {
            base.AddObject("mybooks", mybook);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the myeditions EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTomyeditions(myedition myedition)
        {
            base.AddObject("myeditions", myedition);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="booksModel", Name="myauthor")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class myauthor : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new myauthor object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        public static myauthor Createmyauthor(global::System.Int32 id, global::System.String name)
        {
            myauthor myauthor = new myauthor();
            myauthor.Id = id;
            myauthor.Name = name;
            return myauthor;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("booksModel", "fk_authors_myBooks", "mybooks")]
        public EntityCollection<mybook> mybooks
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<mybook>("booksModel.fk_authors_myBooks", "mybooks");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<mybook>("booksModel.fk_authors_myBooks", "mybooks", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="booksModel", Name="mybook")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class mybook : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new mybook object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="authorId">Initial value of the AuthorId property.</param>
        public static mybook Createmybook(global::System.Int32 id, global::System.Int32 authorId)
        {
            mybook mybook = new mybook();
            mybook.Id = id;
            mybook.AuthorId = authorId;
            return mybook;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 AuthorId
        {
            get
            {
                return _AuthorId;
            }
            set
            {
                OnAuthorIdChanging(value);
                ReportPropertyChanging("AuthorId");
                _AuthorId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("AuthorId");
                OnAuthorIdChanged();
            }
        }
        private global::System.Int32 _AuthorId;
        partial void OnAuthorIdChanging(global::System.Int32 value);
        partial void OnAuthorIdChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("booksModel", "fk_authors_myBooks", "myauthors")]
        public myauthor myauthor
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<myauthor>("booksModel.fk_authors_myBooks", "myauthors").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<myauthor>("booksModel.fk_authors_myBooks", "myauthors").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<myauthor> myauthorReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<myauthor>("booksModel.fk_authors_myBooks", "myauthors");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<myauthor>("booksModel.fk_authors_myBooks", "myauthors", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("booksModel", "myeditionsinmybooks", "myeditions")]
        public EntityCollection<myedition> myeditions
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<myedition>("booksModel.myeditionsinmybooks", "myeditions");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<myedition>("booksModel.myeditionsinmybooks", "myeditions", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="booksModel", Name="myedition")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class myedition : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new myedition object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="title">Initial value of the Title property.</param>
        public static myedition Createmyedition(global::System.Int32 id, global::System.String title)
        {
            myedition myedition = new myedition();
            myedition.Id = id;
            myedition.Title = title;
            return myedition;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                OnTitleChanging(value);
                ReportPropertyChanging("Title");
                _Title = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Title");
                OnTitleChanged();
            }
        }
        private global::System.String _Title;
        partial void OnTitleChanging(global::System.String value);
        partial void OnTitleChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("booksModel", "myeditionsinmybooks", "mybooks")]
        public EntityCollection<mybook> mybooks
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<mybook>("booksModel.myeditionsinmybooks", "mybooks");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<mybook>("booksModel.myeditionsinmybooks", "mybooks", value);
                }
            }
        }

        #endregion

    }

    #endregion

    
}
