﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("northwindModel", "FK_products", "category", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(FW_ENTITY_FRAMEWORK.category), "product", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(FW_ENTITY_FRAMEWORK.product), true)]
[assembly: EdmRelationshipAttribute("northwindModel", "FK_products_hede", "supplier", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(FW_ENTITY_FRAMEWORK.supplier), "product", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(FW_ENTITY_FRAMEWORK.product), true)]

#endregion

namespace FW_ENTITY_FRAMEWORK
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class northwindEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new northwindEntities object using the connection string found in the 'northwindEntities' section of the application configuration file.
        /// </summary>
        public northwindEntities() : base("name=northwindEntities", "northwindEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new northwindEntities object.
        /// </summary>
        public northwindEntities(string connectionString) : base(connectionString, "northwindEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new northwindEntities object.
        /// </summary>
        public northwindEntities(EntityConnection connection) : base(connection, "northwindEntities")
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
        public ObjectSet<category> categories
        {
            get
            {
                if ((_categories == null))
                {
                    _categories = base.CreateObjectSet<category>("categories");
                }
                return _categories;
            }
        }
        private ObjectSet<category> _categories;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<product> products
        {
            get
            {
                if ((_products == null))
                {
                    _products = base.CreateObjectSet<product>("products");
                }
                return _products;
            }
        }
        private ObjectSet<product> _products;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<supplier> suppliers
        {
            get
            {
                if ((_suppliers == null))
                {
                    _suppliers = base.CreateObjectSet<supplier>("suppliers");
                }
                return _suppliers;
            }
        }
        private ObjectSet<supplier> _suppliers;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the categories EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTocategories(category category)
        {
            base.AddObject("categories", category);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the products EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToproducts(product product)
        {
            base.AddObject("products", product);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the suppliers EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTosuppliers(supplier supplier)
        {
            base.AddObject("suppliers", supplier);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="northwindModel", Name="category")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class category : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new category object.
        /// </summary>
        /// <param name="categooryId">Initial value of the CategooryId property.</param>
        public static category Createcategory(global::System.Int32 categooryId)
        {
            category category = new category();
            category.CategooryId = categooryId;
            return category;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 CategooryId
        {
            get
            {
                return _CategooryId;
            }
            set
            {
                if (_CategooryId != value)
                {
                    OnCategooryIdChanging(value);
                    ReportPropertyChanging("CategooryId");
                    _CategooryId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("CategooryId");
                    OnCategooryIdChanged();
                }
            }
        }
        private global::System.Int32 _CategooryId;
        partial void OnCategooryIdChanging(global::System.Int32 value);
        partial void OnCategooryIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String CategoryName
        {
            get
            {
                return _CategoryName;
            }
            set
            {
                OnCategoryNameChanging(value);
                ReportPropertyChanging("CategoryName");
                _CategoryName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("CategoryName");
                OnCategoryNameChanged();
            }
        }
        private global::System.String _CategoryName;
        partial void OnCategoryNameChanging(global::System.String value);
        partial void OnCategoryNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Description
        {
            get
            {
                return _Description;
            }
            set
            {
                OnDescriptionChanging(value);
                ReportPropertyChanging("Description");
                _Description = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Description");
                OnDescriptionChanged();
            }
        }
        private global::System.String _Description;
        partial void OnDescriptionChanging(global::System.String value);
        partial void OnDescriptionChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("northwindModel", "FK_products", "product")]
        public EntityCollection<product> products
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<product>("northwindModel.FK_products", "product");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<product>("northwindModel.FK_products", "product", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="northwindModel", Name="product")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class product : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new product object.
        /// </summary>
        /// <param name="productId">Initial value of the ProductId property.</param>
        /// <param name="productName">Initial value of the ProductName property.</param>
        public static product Createproduct(global::System.Int32 productId, global::System.String productName)
        {
            product product = new product();
            product.ProductId = productId;
            product.ProductName = productName;
            return product;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ProductId
        {
            get
            {
                return _ProductId;
            }
            set
            {
                if (_ProductId != value)
                {
                    OnProductIdChanging(value);
                    ReportPropertyChanging("ProductId");
                    _ProductId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ProductId");
                    OnProductIdChanged();
                }
            }
        }
        private global::System.Int32 _ProductId;
        partial void OnProductIdChanging(global::System.Int32 value);
        partial void OnProductIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String ProductName
        {
            get
            {
                return _ProductName;
            }
            set
            {
                OnProductNameChanging(value);
                ReportPropertyChanging("ProductName");
                _ProductName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("ProductName");
                OnProductNameChanged();
            }
        }
        private global::System.String _ProductName;
        partial void OnProductNameChanging(global::System.String value);
        partial void OnProductNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Decimal> UnitPrice
        {
            get
            {
                return _UnitPrice;
            }
            set
            {
                OnUnitPriceChanging(value);
                ReportPropertyChanging("UnitPrice");
                _UnitPrice = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("UnitPrice");
                OnUnitPriceChanged();
            }
        }
        private Nullable<global::System.Decimal> _UnitPrice;
        partial void OnUnitPriceChanging(Nullable<global::System.Decimal> value);
        partial void OnUnitPriceChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> CategoryId
        {
            get
            {
                return _CategoryId;
            }
            set
            {
                OnCategoryIdChanging(value);
                ReportPropertyChanging("CategoryId");
                _CategoryId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("CategoryId");
                OnCategoryIdChanged();
            }
        }
        private Nullable<global::System.Int32> _CategoryId;
        partial void OnCategoryIdChanging(Nullable<global::System.Int32> value);
        partial void OnCategoryIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> SupplierId
        {
            get
            {
                return _SupplierId;
            }
            set
            {
                OnSupplierIdChanging(value);
                ReportPropertyChanging("SupplierId");
                _SupplierId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("SupplierId");
                OnSupplierIdChanged();
            }
        }
        private Nullable<global::System.Int32> _SupplierId;
        partial void OnSupplierIdChanging(Nullable<global::System.Int32> value);
        partial void OnSupplierIdChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("northwindModel", "FK_products", "category")]
        public category category
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<category>("northwindModel.FK_products", "category").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<category>("northwindModel.FK_products", "category").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<category> categoryReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<category>("northwindModel.FK_products", "category");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<category>("northwindModel.FK_products", "category", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("northwindModel", "FK_products_hede", "supplier")]
        public supplier supplier
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<supplier>("northwindModel.FK_products_hede", "supplier").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<supplier>("northwindModel.FK_products_hede", "supplier").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<supplier> supplierReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<supplier>("northwindModel.FK_products_hede", "supplier");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<supplier>("northwindModel.FK_products_hede", "supplier", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="northwindModel", Name="supplier")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class supplier : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new supplier object.
        /// </summary>
        /// <param name="supplierId">Initial value of the SupplierId property.</param>
        public static supplier Createsupplier(global::System.Int32 supplierId)
        {
            supplier supplier = new supplier();
            supplier.SupplierId = supplierId;
            return supplier;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 SupplierId
        {
            get
            {
                return _SupplierId;
            }
            set
            {
                if (_SupplierId != value)
                {
                    OnSupplierIdChanging(value);
                    ReportPropertyChanging("SupplierId");
                    _SupplierId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("SupplierId");
                    OnSupplierIdChanged();
                }
            }
        }
        private global::System.Int32 _SupplierId;
        partial void OnSupplierIdChanging(global::System.Int32 value);
        partial void OnSupplierIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Company
        {
            get
            {
                return _Company;
            }
            set
            {
                OnCompanyChanging(value);
                ReportPropertyChanging("Company");
                _Company = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Company");
                OnCompanyChanged();
            }
        }
        private global::System.String _Company;
        partial void OnCompanyChanging(global::System.String value);
        partial void OnCompanyChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("northwindModel", "FK_products_hede", "product")]
        public EntityCollection<product> products
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<product>("northwindModel.FK_products_hede", "product");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<product>("northwindModel.FK_products_hede", "product", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}
