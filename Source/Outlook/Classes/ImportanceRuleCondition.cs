﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;

namespace NetOffice.OutlookApi
{
	/// <summary>
	/// CoClass ImportanceRuleCondition 
	/// SupportByVersion Outlook, 12,14,15,16
	/// </summary>
	/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff865041.aspx </remarks>
	[SupportByVersion("Outlook", 12,14,15,16)]
	[EntityType(EntityType.IsCoClass)]
	[TypeId("000610DA-0000-0000-C000-000000000046")]
 	public interface ImportanceRuleCondition : _ImportanceRuleCondition
	{

	}
}
