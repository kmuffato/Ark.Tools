﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWorker.Constants
{
	public static class Test_Constants
	{
		//public const int WorkerSleepDefault = 5;
		//public static int ThreadCountDefault = Environment.ProcessorCount;
		//public const bool IsSingleThreadDefault = false;
		public const bool StartAtCreationDefault = true;
		//public const int RetryCountTreshold = 6;
		//public const int KeepSessionAliveInMinutes = 30;

		public const string DataTimezone = "CET";
		public const string ProviderName = "TestWorker";

		public const string RebusConnString = "Endpoint=sb://artesian-ops.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=2yyjCkOyAfTaRZvZM95fAGZbvUYRY8FlvdkvJ+FIWCA=";

	}
}
