using System;
using System.Data;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data.Common;

namespace STK_Service
{
    [ServiceContract]
    public interface IWS_STK
    {
        #region 通用模块

        //[OperationContract]
        //DataSet ExecuteDataSet(string sql);
        //[OperationContract]
        //int ExecuteNoQuery(string sql);

        #endregion

        #region 系统管理

        /// <summary>
        /// 测试连接
        /// </summary>
        [OperationContract]
        string SYS_Test(string ATestName);

        /// <summary>
        /// 系统登录
        /// </summary>
        [OperationContract]
        void SYS_Login(ref DataType_User model);

        /// <summary>
        /// 系统登录用户的菜单
        /// </summary>
        [OperationContract]
        DataSet SYS_Login_Menu(ref DataType_User model);

        /// <summary>
        /// 退出登录
        /// </summary>
        [OperationContract]
        void SYS_Logout(DataType_User model);

        /// <summary>
        /// 用户列表
        /// </summary>
        [OperationContract]
        DataSet Sys_User_List(DataType_User model);

        /// <summary>
        ///  用户编辑
        /// </summary>
        [OperationContract]
        void Sys_User_Edit(ref DataType_User model);

        /// <summary>
        /// 角色列表
        /// </summary>
        [OperationContract]
        DataSet Sys_Role_List(DataType_Role model);

        /// <summary>
        ///  角色编辑
        /// </summary>
        [OperationContract]
        void Sys_Role_Edit(ref DataType_Role model);

        /// <summary>
        /// 菜单列表
        /// </summary>
        [OperationContract]
        DataSet Sys_Menu_List(int ARoleID);

        /// <summary>
        /// 参数读取
        /// </summary>
        [OperationContract]
        void SYS_Param_Get(ref DataType_Param model);

        /// <summary>
        /// 参数设置
        /// </summary>
        [OperationContract]
        void SYS_Param_Set(ref DataType_Param model);

        /// <summary>
        /// 表格读取
        /// </summary>
        [OperationContract]
        void SYS_Grid_Get (ref DataType_Grid model);

        /// <summary>
        /// 表格设置--保存用户对表格配置
        /// </summary>
        [OperationContract]
        void SYS_Grid_Set(ref DataType_Grid model);

        [OperationContract]
        string GetTableDef(string tableid);       
        #endregion

        #region 库存管理
        #region 基础设置

        /// <summary>
        /// 储物箱
        /// </summary>
        [OperationContract]
        DataSet BAS_储物箱_List(DataType_仓库 model);
        [OperationContract]
        void BAS_储物箱_Edit(ref DataType_仓库 model);

        /// <summary>
        /// 货架
        /// </summary>
        [OperationContract]
        DataSet BAS_货架_List(DataType_仓库 model);
        [OperationContract]
        void BAS_货架_Edit(ref DataType_仓库 model);

        /// <summary>
        /// 仓库
        /// </summary>
        [OperationContract]
        DataSet BAS_仓库_List(DataType_仓库 model);
        [OperationContract]
        void BAS_仓库_Edit(ref DataType_仓库 model);
        [OperationContract]
        DataSet BAS_仓库_类型_List();

        /// <summary>
        /// 存货
        /// </summary>
        [OperationContract]
        DataSet BAS_存货_List(DataType_存货 model);
        [OperationContract]
        void BAS_存货_Edit(ref DataType_存货 model);      

        /// <summary>
        /// 存货_类别 
        /// </summary>
        [OperationContract]
        DataSet BAS_存货_类别_List(DataType_存货_类别 model);
        [OperationContract]
        void BAS_存货_类别_Edit(ref DataType_存货_类别 model);
        [OperationContract]
        DataSet BAS_存货_类别_Down(ref DataType_存货_类别 model);

        /// <summary>
        /// 期初
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [OperationContract]
        DataSet BAS_期初库存_List(DataType_库存管理 model);
        [OperationContract]
        void BAS_期初库存_Edit(ref DataType_库存管理 model);
        /// <summary>
        /// 供应商 
        /// </summary>
        [OperationContract]
        DataSet BAS_供应商_List(DataType_供应商 model);
        [OperationContract]
        void BAS_供应商_Edit(ref DataType_供应商 model);
        #endregion
        #region 库存管理
        /// <summary>
        /// 出库
        /// </summary>
        [OperationContract]
        DataSet STK_库存出库_List(DataType_库存管理 model);
        [OperationContract]
        void STK_库存出库_Edit(ref DataType_库存管理 model);
        /// <summary>
        /// 入库
        /// </summary>
        [OperationContract]
        DataSet STK_库存入库_List(DataType_库存管理 model);
        [OperationContract]
        void STK_库存入库_Edit(ref DataType_库存管理 model);
        #endregion
        #region 期末管理
        /// <summary>
        /// 会计期间
        /// </summary>
        [OperationContract]
        DataSet BAS_会计期间_List(DataType_会计期间 model);
        [OperationContract]
        void BAS_会计期间_Edit(ref DataType_会计期间 model);
        #endregion
        #region 库存报表
        /// <summary>
        /// 库存分布
        /// </summary>
        [OperationContract]
        DataSet STK_库存分布_List(DataType_库存分布 model);
        /// <summary>
        /// 结账
        /// </summary>
        [OperationContract]
        DataSet STK_库存总账_List(DataType_库存管理 model);
        #endregion
        #endregion
    }

    #region 模型/契约 定义

    #region 模型基类
    [DataContract]
    public class ModelBase
    {
        [DataMember]
        public string ExAction { get; set; }
        [DataMember]
        public int ExResult { get; set; }
        [DataMember]
        public string ErrorMsg { get; set; }

        [DataMember]
        public string LoginUserCode { get; set; }
        [DataMember]
        public string LoginUserPswd { get; set; }

        [DataMember]
        public int PageRows { get; set; }
        [DataMember]
        public int PageIndex { get; set; }
        [DataMember]
        public int PageCount { get; set; }
        [DataMember]
        public int RowsCount { get; set; }

        [DataMember]
        public DateTime Date_B { get; set; }
        [DataMember]
        public DateTime Date_E { get; set; }
    }
    #endregion

    #region 系统管理

    [DataContract]
    public class DataType_User : ModelBase
    {
        [DataMember]
        public string LoginName { get; set; }
        [DataMember]
        public string LoginPswd { get; set; }
        [DataMember]
        public string LoginAddr { get; set; }
        [DataMember]
        public DateTime LoginDate { get; set; }
        [DataMember]
        public int LoginID { get; set; }

        [DataMember]
        public string UserCode { get; set; }
        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public string UserPswd { get; set; }
        [DataMember]
        public string MobiPhone { get; set; }
        [DataMember]
        public string WorkPhone { get; set; }
        [DataMember]
        public string UserEmail { get; set; }
        [DataMember]
        public string RoleList { get; set; }
        [DataMember]
        public int UserState { get; set; }
        [DataMember]
        public string 所在店铺编码 { get; set; }
        [DataMember]
        public string 职务 { get; set; }
        [DataMember]
        public string 工作岗位 { get; set; }
        [DataMember]
        public string 可入仓库编码 { get; set; }
        [DataMember]
        public string 可出仓库编码 { get; set; }
        [DataMember]
        public DateTime 入职时间 { get; set; }
        [DataMember]
        public DateTime 离职时间 { get; set; }
        [DataMember]
        public string 家庭住址 { get; set; }
        [DataMember]
        public string 身份证号 { get; set; }
        [DataMember]
        public string 备注 { get; set; }


        [DataMember]
        public string NewUserCode { get; set; }
        [DataMember]
        public string NewUserPswd { get; set; }
        [DataMember]
        public string WorkName { get; set; }
    }

    [DataContract]
    public class DataType_Role : ModelBase
    {
        [DataMember]
        public int RoleID { get; set; }
        [DataMember]
        public string RoleName { get; set; }
        [DataMember]
        public string RoleMemo { get; set; }
        [DataMember]
        public string RoleMenu { get; set; }
    }
    
    [DataContract]
    public class DataType_Param : ModelBase
    {
        [DataMember]
        public string DBVersion { get; set; }
        [DataMember]
        public string WSVersion { get; set; }
        [DataMember]
        public string CSVersion { get; set; }
        
        [DataMember]
        public string AppName { get; set; }
        //[DataMember]  --基类已有
        //public int PageRows { get; set; }
        [DataMember]
        public int DP_Number { get; set; }
        [DataMember]
        public int DP_Money { get; set; }

        [DataMember]
        public string 公司名称 { get; set; }
        [DataMember]
        public string 公司地址 { get; set; }
        [DataMember]
        public string 公司电话 { get; set; }
        [DataMember]
        public string 公司传真 { get; set; }
        [DataMember]
        public string 公司负责人 { get; set; }
    }

    [DataContract]
    public class DataType_Grid : ModelBase
    {
        [DataMember]
        public string GridName { get; set; }
        [DataMember]
        public string GridDefine { get; set; }
        [DataMember]
        public string GridMemo { get; set; }

        [DataMember]
        public string GridUser { get; set; }
    }

    #endregion

    #region  库存管理
    #region 基础设置
    //T_BAS_会计期间
    [DataContract]
    public class DataType_会计期间 : ModelBase
    {
        [DataMember]
        public string 仓库编码 { get; set; }
        [DataMember]
        public string 会计期间 { get; set; }
        [DataMember]
        public DateTime 会计期间_B { get; set; }
        [DataMember]
        public DateTime 会计期间_E { get; set; }
        //
        [DataMember]
        public string 年份 { get; set; }

    }
    //T_BAS_物料	
    [DataContract]
    public class DataType_存货 : ModelBase
    {
        [DataMember]
        public string 存货编码 { get; set; }
        [DataMember]
        public string 存货名称 { get; set; }
        [DataMember]
        public string 助记码 { get; set; }
        [DataMember]
        public string 规格型号 { get; set; }
        [DataMember]
        public string 类别编码 { get; set; }
        [DataMember]
        public int 类别序号 { get; set; }
        [DataMember]
        public decimal 库存下限 { get; set; }
        [DataMember]
        public decimal 库存上限 { get; set; }
        [DataMember]
        public string 计量单位 { get; set; }
        [DataMember]
        public decimal 存货单价 { get; set; }
        [DataMember]
        public string 默认仓库编码 { get; set; }
        [DataMember]
        public int 存货状态 { get; set; }
        [DataMember]
        public string 备注 { get; set; }
        [DataMember]
        public int 上一个序号 { get; set; }
        //
        [DataMember]
        public bool 包含下级 { get; set; }
        [DataMember]
        public bool 可出库 { get; set; } 
    }

    //T_BAS_存货_类别	
    [DataContract]
    public class DataType_存货_类别 : ModelBase
    {
        [DataMember]
        public string 类别编码 { get; set; }
        [DataMember]
        public string 上级编码 { get; set; }
        [DataMember]
        public string 类别名称 { get; set; }
        [DataMember]
        public string 助记词 { get; set; }
        [DataMember]
        public int 类别类型 { get; set; }
        [DataMember]
        public int 类别状态 { get; set; }
        [DataMember]
        public string 备注 { get; set; }
        [DataMember]
        public string 创建人编码 { get; set; }
        [DataMember]
        public DateTime 创建时间 { get; set; }
    }

    //T_BAS_储物箱	
    [DataContract]
    public class DataType_储物箱 : ModelBase
    {
        [DataMember]
        public string 储物箱编码 { get; set; }
        [DataMember]
        public string 货架编码 { get; set; }
        [DataMember]
        public string 储物箱名称 { get; set; }
        [DataMember]
        public string 物料编码 { get; set; }
        [DataMember]
        public int 状态 { get; set; }
        [DataMember]
        public string 上限值 { get; set; }
        [DataMember]
        public string 备注 { get; set; }
        [DataMember]
        public string MxDataXML { get; set; }
        //
        [DataMember]
        public string 仓库编码 { get; set; }

    }

    //T_BAS_货架	
    [DataContract]
    public class DataType_货架 : ModelBase
    {
        [DataMember]
        public string 货架编码 { get; set; }
        [DataMember]
        public string 货架名称 { get; set; }
        [DataMember]
        public string 位置编码 { get; set; }
        [DataMember]
        public int 货架状态 { get; set; }
        [DataMember]
        public int 储物箱数量 { get; set; }
        [DataMember]
        public string 仓库编码 { get; set; }
        [DataMember]
        public string 备注 { get; set; }
    }

    //T_BAS_仓库	
    [DataContract]
    public class DataType_仓库 : ModelBase
    {
        [DataMember]
        public string 仓库编码 { get; set; }
        [DataMember]
        public string 仓库名称 { get; set; }
        [DataMember]
        public string 上级编码 { get; set; }
        [DataMember]
        public int 仓库类型 { get; set; }
        [DataMember]
        public string 仓库地址 { get; set; }
        [DataMember]
        public string 仓库电话 { get; set; }
        [DataMember]
        public string 仓库负责人 { get; set; }
        [DataMember]
        public decimal 仓库容量 { get; set; }
        [DataMember]
        public int 仓库状态 { get; set; }
        [DataMember]
        public string 备注 { get; set; }
        [DataMember]
        public string 创建人编码 { get; set; }
        [DataMember]
        public DateTime 创建时间 { get; set; }
        [DataMember]
        public string 仓库位置编码 { get; set; }
        //
        [DataMember]
        public int 包含所有项 { get; set; }
        [DataMember]
        public string MxDataXML { get; set; }
    }

    [DataContract]
    public class DataType_供应商 : ModelBase
    {
        [DataMember]
        public string 供应商编码 { get; set; }
        [DataMember]
        public string 供应商名称 { get; set; }
        [DataMember]
        public string 地址 { get; set; }
        [DataMember]
        public string 邮编 { get; set; }
        [DataMember]
        public string 电话 { get; set; }
        [DataMember]
        public string 传真 { get; set; }
        [DataMember]
        public string 联系人 { get; set; }
        [DataMember]
        public string 联系人手机 { get; set; }
        [DataMember]
        public string 开户银行 { get; set; }
        [DataMember]
        public string 银行账号 { get; set; }
        [DataMember]
        public string 业务范围 { get; set; }
        [DataMember]
        public string 备注 { get; set; }
    }
    #endregion        
    #region 库存管理

    //DataType_申请单	
    [DataContract]
    public class DataType_库存管理 : ModelBase
    {
        [DataMember]
        public string 单据编码 { get; set; }
        [DataMember]
        public string 单据类型 { get; set; }
        [DataMember]
        public string 原始单号 { get; set; }
        [DataMember]
        public string 供应商编码 { get; set; }
        [DataMember]
        public string 仓库编码 { get; set; }
        [DataMember]
        public DateTime 业务日期 { get; set; }
        [DataMember]
        public string 制单人编码 { get; set; }
        [DataMember]
        public string 备注 { get; set; }
        //
        //查询部分  
        [DataMember]
        public DateTime 开始时间 { get; set; }
        [DataMember]
        public DateTime 结束时间 { get; set; }
        [DataMember]
        public Boolean 所有未审核 { get; set; }
        [DataMember]
        public string MxDataXML { get; set; }
        //
        //
        [DataMember]
        public string 存货编码 { get; set; }
        [DataMember]
        public string 存货名称 { get; set; }
        [DataMember]
        public decimal 期初单价 { get; set; }
        [DataMember]
        public decimal 期初数量 { get; set; }
        [DataMember]
        public decimal 期初金额 { get; set; }
        [DataMember]
        public string 货架编码 { get; set; }
        //
        [DataMember]
        public string 类别编码 { get; set; }
        [DataMember]
        public bool 包含下级 { get; set; }

        //
        [DataMember]
        public string 会计期间 { get; set; }
    }

    #endregion
    #region 库存报表

    [DataContract]
    public class DataType_库存分布 : ModelBase
    {
        [DataMember]
        public string 仓库编码 { get; set; }
        [DataMember]
        public string 存货名称 { get; set; }
        [DataMember]
        public string 类别编码 { get; set; }
        [DataMember]
        public bool 包含下级 { get; set; }
    }

    [DataContract]
    public class DataType_库存报表 : ModelBase
    {
        [DataMember]
        public string 查询类型 { get; set; }
        [DataMember]
        public DateTime 查询日期 { get; set; }
        [DataMember]
        public DateTime 开始日期 { get; set; }
        [DataMember]
        public DateTime 结束日期 { get; set; }
        [DataMember]
        public string 仓库编码 { get; set; }
        [DataMember]
        public string 商品编码 { get; set; }
        [DataMember]
        public int 显示类型 { get; set; }
        [DataMember]
        public Boolean 显示空行 { get; set; }
    }

    #endregion
    #region

    #endregion
    #endregion 
    #endregion
}
