//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     创建人：wms
//     创建时间：2019/12/1 14:30:04
//     说明：
// </auto-generated>
//------------------------------------------------------------------------------
using JadeFramework.Core.Dapper;
using JadeFramework.WorkFlow;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MsSystem.WF.Model
{
    /// <summary>
    /// 催办记录表
    /// </summary>
    [Table("wf_workflow_urge")]
    public class WfWorkflowUrge : Entity
    {
        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// 流程id
        /// </summary>
        public Guid FlowId { get; set; }

        /// <summary>
        /// 当前节点id
        /// </summary>
        public Guid NodeId { get; set; }

        /// <summary>
        /// 发送人
        /// </summary>
        public string Sender { get; set; }

        /// <summary>
        /// 催办人
        /// </summary>
        public string UrgeUser { get; set; }

        /// <summary>
        /// 催办信息
        /// </summary>
        public string UrgeContent { get; set; }

        /// <summary>
        /// 催办次数
        /// </summary>
        public byte UrgeTimes { get; set; }

    }
    public class WfWorkflowUrgeMapper : ClassMapper<WfWorkflowUrge>
    {
        public WfWorkflowUrgeMapper()
        {
            Table("wf_workflow_urge");
            AutoMap();
        }
    }
}
