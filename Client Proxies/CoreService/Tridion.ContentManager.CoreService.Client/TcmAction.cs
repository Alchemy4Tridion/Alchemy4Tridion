using System;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	public enum TcmAction
	{
		None,
		CheckOut,
		CheckIn,
		UndoCheckOut,
		HistoryList,
		Rollback,
		Localize,
		Unlocalize,
		Publish,
		UnPublish,
		RePublish,
		Search,
		Edit,
		AssignActivity,
		View,
		Delete,
		Cut,
		Copy,
		Enable,
		Disable,
		PermissionManaged,
		WorkflowManaged,
		BlueprintManaged,
		StartActivity,
		FinishActivity,
		RestartActivity,
		FinishProcess,
		Execute,
		Abort,
		Classification,
		AddItem,
		RemoveItem,
		Promote,
		Demote
	}
}
