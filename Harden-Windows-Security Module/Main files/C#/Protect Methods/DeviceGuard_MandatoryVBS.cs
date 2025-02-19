﻿using System;

namespace HardenWindowsSecurity;

public partial class DeviceGuard
{

	/// <summary>
	/// Enables mandatory mode of VBS and Memory Integrity
	/// </summary>
	/// <exception cref="ArgumentNullException"></exception>
	public static void DeviceGuard_MandatoryVBS()
	{
		ChangePSConsoleTitle.Set("🖥️ Device Guard");

		Logger.LogMessage("Setting VBS and Memory Integrity in Mandatory Mode", LogTypeIntel.Information);

		foreach (HardeningRegistryKeys.CsvRecord Item in GlobalVars.RegistryCSVItems)
		{
			if (string.Equals(Item.Category, "DeviceGuard_MandatoryVBS", StringComparison.OrdinalIgnoreCase))
			{
				RegistryEditor.EditRegistry(Item.Path, Item.Key, Item.Value, Item.Type, Item.Action);
			}
		}

	}
}
