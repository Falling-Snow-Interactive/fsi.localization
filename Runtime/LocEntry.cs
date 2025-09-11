using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization;

namespace Fsi.Localization
{
	[Serializable]
	public class LocEntry
	{
		[SerializeField]
		private LocalizedString entry;

		public bool IsSet => !entry.IsEmpty;

		public string GetLocalizedString(Dictionary<string, string> args, string fallback = "no_loc")
		{
			if (entry.IsEmpty)
			{
				Debug.LogError($"LocEntry | No loc found. \nUsing fallback ({fallback}).");
			}
			return entry.IsEmpty ? fallback : entry.GetLocalizedString(args);
		}

		public string GetLocalizedString(string fallback = "no_loc")
		{
			if (entry.IsEmpty)
			{
				Debug.LogError($"LocEntry | No loc found. \nUsing fallback ({fallback}).");
			}
			return entry.IsEmpty ? fallback : entry.GetLocalizedString();
		}
	}
}