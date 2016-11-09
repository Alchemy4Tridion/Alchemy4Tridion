using System;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	public static class ApplicableActionsExtensions
	{
		public static bool IsActionAllowed(this ApplicableActionsData applicableActions, string customAction)
		{
			return applicableActions.IsActionApplicable(customAction) && applicableActions.Actions[customAction];
		}

		public static bool IsActionAllowed(this ApplicableActionsData applicableActions, TcmAction tcmAction)
		{
			return applicableActions.IsActionAllowed(ApplicableActionsExtensions.GetTcmActionString(tcmAction));
		}

		public static bool IsActionApplicable(this ApplicableActionsData applicableActions, string customAction)
		{
			return applicableActions != null && applicableActions.Actions != null && applicableActions.Actions.ContainsKey(customAction);
		}

		public static bool IsActionApplicable(this ApplicableActionsData applicableActions, TcmAction tcmAction)
		{
			return applicableActions.IsActionApplicable(ApplicableActionsExtensions.GetTcmActionString(tcmAction));
		}

		private static string GetTcmActionString(TcmAction action)
		{
			return "tcm:" + action;
		}
	}
}
