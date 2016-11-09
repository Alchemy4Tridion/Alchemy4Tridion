using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0"), DebuggerStepThrough, DataContract(Name = "BatchData", Namespace = "http://www.sdltridion.com/ContentManager/R6")]
	public class BatchData : SystemWideObjectData
	{
		private int? NumberOfDoneOperationsField;

		private BatchOperationData[] OperationsField;

		private LinkToUserData PerformerField;

		private DateTime? StartAtField;

		private int? TotalNumberOfOperationsField;

		private AccessTokenData PerformerAccessTokenField;

		[DataMember(EmitDefaultValue = false)]
		public int? NumberOfDoneOperations
		{
			get
			{
				return this.NumberOfDoneOperationsField;
			}
			set
			{
				this.NumberOfDoneOperationsField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public BatchOperationData[] Operations
		{
			get
			{
				return this.OperationsField;
			}
			set
			{
				this.OperationsField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public LinkToUserData Performer
		{
			get
			{
				return this.PerformerField;
			}
			set
			{
				this.PerformerField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public DateTime? StartAt
		{
			get
			{
				return this.StartAtField;
			}
			set
			{
				this.StartAtField = value;
			}
		}

		[DataMember(EmitDefaultValue = false)]
		public int? TotalNumberOfOperations
		{
			get
			{
				return this.TotalNumberOfOperationsField;
			}
			set
			{
				this.TotalNumberOfOperationsField = value;
			}
		}

		[DataMember(EmitDefaultValue = false, Order = 5)]
		public AccessTokenData PerformerAccessToken
		{
			get
			{
				return this.PerformerAccessTokenField;
			}
			set
			{
				this.PerformerAccessTokenField = value;
			}
		}
	}
}
