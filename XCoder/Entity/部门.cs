using System;
using System.Collections.Generic;
using System.ComponentModel;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace COMCMS.Core
{
    /// <summary>部门</summary>
    [Serializable]
    [DataObject]
    [Description("部门")]
    [BindTable("Department", Description = "部门", ConnName = "dbconn", DbType = DatabaseType.SqlServer)]
    public partial class Department : IDepartment
    {
        #region 属性
        private Int32 _Id;
        /// <summary>编号</summary>
        [DisplayName("编号")]
        [Description("编号")]
        [DataObjectField(true, true, false, 0)]
        [BindColumn("Id", "编号", "")]
        public Int32 Id { get => _Id; set { if (OnPropertyChanging(__.Id, value)) { _Id = value; OnPropertyChanged(__.Id); } } }

        private String _DepartmentName;
        /// <summary>部门名称</summary>
        [DisplayName("部门名称")]
        [Description("部门名称")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("DepartmentName", "部门名称", "")]
        public String DepartmentName { get => _DepartmentName; set { if (OnPropertyChanging(__.DepartmentName, value)) { _DepartmentName = value; OnPropertyChanged(__.DepartmentName); } } }

        private Int32 _PId;
        /// <summary>上级部门ID</summary>
        [DisplayName("上级部门ID")]
        [Description("上级部门ID")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("PId", "上级部门ID", "")]
        public Int32 PId { get => _PId; set { if (OnPropertyChanging(__.PId, value)) { _PId = value; OnPropertyChanged(__.PId); } } }

        private Int32 _Level;
        /// <summary>级别</summary>
        [DisplayName("级别")]
        [Description("级别")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Level", "级别", "")]
        public Int32 Level { get => _Level; set { if (OnPropertyChanging(__.Level, value)) { _Level = value; OnPropertyChanged(__.Level); } } }

        private String _Location;
        /// <summary>路径</summary>
        [DisplayName("路径")]
        [Description("路径")]
        [DataObjectField(false, false, true, 100)]
        [BindColumn("Location", "路径", "")]
        public String Location { get => _Location; set { if (OnPropertyChanging(__.Location, value)) { _Location = value; OnPropertyChanged(__.Location); } } }

        private String _DepartmentDescription;
        /// <summary>部门说明</summary>
        [DisplayName("部门说明")]
        [Description("部门说明")]
        [DataObjectField(false, false, true, 250)]
        [BindColumn("DepartmentDescription", "部门说明", "")]
        public String DepartmentDescription { get => _DepartmentDescription; set { if (OnPropertyChanging(__.DepartmentDescription, value)) { _DepartmentDescription = value; OnPropertyChanged(__.DepartmentDescription); } } }

        private String _Pic;
        /// <summary>部门图片</summary>
        [DisplayName("部门图片")]
        [Description("部门图片")]
        [DataObjectField(false, false, true, 250)]
        [BindColumn("Pic", "部门图片", "")]
        public String Pic { get => _Pic; set { if (OnPropertyChanging(__.Pic, value)) { _Pic = value; OnPropertyChanged(__.Pic); } } }

        private Int32 _Rank;
        /// <summary>排序</summary>
        [DisplayName("排序")]
        [Description("排序")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Rank", "排序", "")]
        public Int32 Rank { get => _Rank; set { if (OnPropertyChanging(__.Rank, value)) { _Rank = value; OnPropertyChanged(__.Rank); } } }

        private Int32 _IsNotAllowDel;
        /// <summary>是否不允许删除</summary>
        [DisplayName("是否不允许删除")]
        [Description("是否不允许删除")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("IsNotAllowDel", "是否不允许删除", "")]
        public Int32 IsNotAllowDel { get => _IsNotAllowDel; set { if (OnPropertyChanging(__.IsNotAllowDel, value)) { _IsNotAllowDel = value; OnPropertyChanged(__.IsNotAllowDel); } } }

        private String _Powers;
        /// <summary>部门权限</summary>
        [DisplayName("部门权限")]
        [Description("部门权限")]
        [DataObjectField(false, false, true, -1)]
        [BindColumn("Powers", "部门权限", "", Master = true)]
        public String Powers { get => _Powers; set { if (OnPropertyChanging(__.Powers, value)) { _Powers = value; OnPropertyChanged(__.Powers); } } }

        private Int32 _IsDel;
        /// <summary>是否删除</summary>
        [DisplayName("是否删除")]
        [Description("是否删除")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("IsDel", "是否删除", "")]
        public Int32 IsDel { get => _IsDel; set { if (OnPropertyChanging(__.IsDel, value)) { _IsDel = value; OnPropertyChanged(__.IsDel); } } }

        private String _Tel;
        /// <summary>联系电话</summary>
        [DisplayName("联系电话")]
        [Description("联系电话")]
        [DataObjectField(false, false, true, 30)]
        [BindColumn("Tel", "联系电话", "")]
        public String Tel { get => _Tel; set { if (OnPropertyChanging(__.Tel, value)) { _Tel = value; OnPropertyChanged(__.Tel); } } }

        private String _Fax;
        /// <summary>传真</summary>
        [DisplayName("传真")]
        [Description("传真")]
        [DataObjectField(false, false, true, 30)]
        [BindColumn("Fax", "传真", "")]
        public String Fax { get => _Fax; set { if (OnPropertyChanging(__.Fax, value)) { _Fax = value; OnPropertyChanged(__.Fax); } } }

        private String _Email;
        /// <summary>邮件</summary>
        [DisplayName("邮件")]
        [Description("邮件")]
        [DataObjectField(false, false, true, 100)]
        [BindColumn("Email", "邮件", "")]
        public String Email { get => _Email; set { if (OnPropertyChanging(__.Email, value)) { _Email = value; OnPropertyChanged(__.Email); } } }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        public override Object this[String name]
        {
            get
            {
                switch (name)
                {
                    case __.Id: return _Id;
                    case __.DepartmentName: return _DepartmentName;
                    case __.PId: return _PId;
                    case __.Level: return _Level;
                    case __.Location: return _Location;
                    case __.DepartmentDescription: return _DepartmentDescription;
                    case __.Pic: return _Pic;
                    case __.Rank: return _Rank;
                    case __.IsNotAllowDel: return _IsNotAllowDel;
                    case __.Powers: return _Powers;
                    case __.IsDel: return _IsDel;
                    case __.Tel: return _Tel;
                    case __.Fax: return _Fax;
                    case __.Email: return _Email;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case __.Id: _Id = value.ToInt(); break;
                    case __.DepartmentName: _DepartmentName = Convert.ToString(value); break;
                    case __.PId: _PId = value.ToInt(); break;
                    case __.Level: _Level = value.ToInt(); break;
                    case __.Location: _Location = Convert.ToString(value); break;
                    case __.DepartmentDescription: _DepartmentDescription = Convert.ToString(value); break;
                    case __.Pic: _Pic = Convert.ToString(value); break;
                    case __.Rank: _Rank = value.ToInt(); break;
                    case __.IsNotAllowDel: _IsNotAllowDel = value.ToInt(); break;
                    case __.Powers: _Powers = Convert.ToString(value); break;
                    case __.IsDel: _IsDel = value.ToInt(); break;
                    case __.Tel: _Tel = Convert.ToString(value); break;
                    case __.Fax: _Fax = Convert.ToString(value); break;
                    case __.Email: _Email = Convert.ToString(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得部门字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary>编号</summary>
            public static readonly Field Id = FindByName(__.Id);

            /// <summary>部门名称</summary>
            public static readonly Field DepartmentName = FindByName(__.DepartmentName);

            /// <summary>上级部门ID</summary>
            public static readonly Field PId = FindByName(__.PId);

            /// <summary>级别</summary>
            public static readonly Field Level = FindByName(__.Level);

            /// <summary>路径</summary>
            public static readonly Field Location = FindByName(__.Location);

            /// <summary>部门说明</summary>
            public static readonly Field DepartmentDescription = FindByName(__.DepartmentDescription);

            /// <summary>部门图片</summary>
            public static readonly Field Pic = FindByName(__.Pic);

            /// <summary>排序</summary>
            public static readonly Field Rank = FindByName(__.Rank);

            /// <summary>是否不允许删除</summary>
            public static readonly Field IsNotAllowDel = FindByName(__.IsNotAllowDel);

            /// <summary>部门权限</summary>
            public static readonly Field Powers = FindByName(__.Powers);

            /// <summary>是否删除</summary>
            public static readonly Field IsDel = FindByName(__.IsDel);

            /// <summary>联系电话</summary>
            public static readonly Field Tel = FindByName(__.Tel);

            /// <summary>传真</summary>
            public static readonly Field Fax = FindByName(__.Fax);

            /// <summary>邮件</summary>
            public static readonly Field Email = FindByName(__.Email);

            static Field FindByName(String name) => Meta.Table.FindByName(name);
        }

        /// <summary>取得部门字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary>编号</summary>
            public const String Id = "Id";

            /// <summary>部门名称</summary>
            public const String DepartmentName = "DepartmentName";

            /// <summary>上级部门ID</summary>
            public const String PId = "PId";

            /// <summary>级别</summary>
            public const String Level = "Level";

            /// <summary>路径</summary>
            public const String Location = "Location";

            /// <summary>部门说明</summary>
            public const String DepartmentDescription = "DepartmentDescription";

            /// <summary>部门图片</summary>
            public const String Pic = "Pic";

            /// <summary>排序</summary>
            public const String Rank = "Rank";

            /// <summary>是否不允许删除</summary>
            public const String IsNotAllowDel = "IsNotAllowDel";

            /// <summary>部门权限</summary>
            public const String Powers = "Powers";

            /// <summary>是否删除</summary>
            public const String IsDel = "IsDel";

            /// <summary>联系电话</summary>
            public const String Tel = "Tel";

            /// <summary>传真</summary>
            public const String Fax = "Fax";

            /// <summary>邮件</summary>
            public const String Email = "Email";
        }
        #endregion
    }

    /// <summary>部门接口</summary>
    public partial interface IDepartment
    {
        #region 属性
        /// <summary>编号</summary>
        Int32 Id { get; set; }

        /// <summary>部门名称</summary>
        String DepartmentName { get; set; }

        /// <summary>上级部门ID</summary>
        Int32 PId { get; set; }

        /// <summary>级别</summary>
        Int32 Level { get; set; }

        /// <summary>路径</summary>
        String Location { get; set; }

        /// <summary>部门说明</summary>
        String DepartmentDescription { get; set; }

        /// <summary>部门图片</summary>
        String Pic { get; set; }

        /// <summary>排序</summary>
        Int32 Rank { get; set; }

        /// <summary>是否不允许删除</summary>
        Int32 IsNotAllowDel { get; set; }

        /// <summary>部门权限</summary>
        String Powers { get; set; }

        /// <summary>是否删除</summary>
        Int32 IsDel { get; set; }

        /// <summary>联系电话</summary>
        String Tel { get; set; }

        /// <summary>传真</summary>
        String Fax { get; set; }

        /// <summary>邮件</summary>
        String Email { get; set; }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        Object this[String name] { get; set; }
        #endregion
    }
}