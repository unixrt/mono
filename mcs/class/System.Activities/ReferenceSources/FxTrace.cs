using System;
using System.Collections.Generic;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.Diagnostics;
using System.Security;
using System.Threading;

namespace System.Activities
{
    internal static class FxTrace
    {
        private const string baseEventSourceName = "System.Activities";

        private const string EventSourceVersion = "4.0.0.0";

        private static Guid etwProviderId;

        private static string eventSourceName;

        private static ExceptionTrace exceptionTrace;

        private static bool[] enabledEvents;

        private static SortedSet<ushort> end2EndEvents;

        [SecurityCritical]
        private static EventDescriptor[] eventDescriptors;

        private static object lockObject;

        private static bool tracingEnabled;

        private static bool shouldTraceVerbose;

        private static bool shouldTraceInformation;

        private static bool shouldTraceWarning;

        private static bool shouldTraceError;

        private static bool shouldTraceCritical;

        private static bool shouldTraceVerboseToTraceSource;

        private static bool shouldTraceInformationToTraceSource;

        private static bool shouldTraceWarningToTraceSource;

        private static bool shouldTraceErrorToTraceSource;

        private static bool shouldTraceCriticalToTraceSource;

        private static EtwDiagnosticTrace diagnosticTrace;

        public static EventLogger EventLog
        {
            get
            {
                return new EventLogger(FxTrace.EventSourceName, FxTrace.Trace);
            }
        }

        private static string EventSourceName
        {
            get
            {
                if (FxTrace.eventSourceName == null)
                {
                    FxTrace.eventSourceName = string.Concat("System.Activities", " ", "4.0.0.0");
                }
                return FxTrace.eventSourceName;
            }
        }

        public static ExceptionTrace Exception
        {
            get
            {
                if (FxTrace.exceptionTrace == null)
                {
                    FxTrace.exceptionTrace = new ExceptionTrace(FxTrace.EventSourceName, FxTrace.Trace);
                }
                return FxTrace.exceptionTrace;
            }
        }

        public static bool ShouldTraceCritical
        {
            get
            {
                return FxTrace.shouldTraceCritical;
            }
        }

        public static bool ShouldTraceCriticalToTraceSource
        {
            get
            {
                return FxTrace.shouldTraceCriticalToTraceSource;
            }
        }

        public static bool ShouldTraceError
        {
            get
            {
                return FxTrace.shouldTraceError;
            }
        }

        public static bool ShouldTraceErrorToTraceSource
        {
            get
            {
                return FxTrace.shouldTraceErrorToTraceSource;
            }
        }

        public static bool ShouldTraceInformation
        {
            get
            {
                return FxTrace.shouldTraceInformation;
            }
        }

        public static bool ShouldTraceInformationToTraceSource
        {
            get
            {
                return FxTrace.shouldTraceInformationToTraceSource;
            }
        }

        public static bool ShouldTraceVerbose
        {
            get
            {
                return FxTrace.shouldTraceVerbose;
            }
        }

        public static bool ShouldTraceVerboseToTraceSource
        {
            get
            {
                return FxTrace.shouldTraceVerboseToTraceSource;
            }
        }

        public static bool ShouldTraceWarning
        {
            get
            {
                return FxTrace.shouldTraceWarning;
            }
        }

        public static bool ShouldTraceWarningToTraceSource
        {
            get
            {
                return FxTrace.shouldTraceWarningToTraceSource;
            }
        }

        public static EtwDiagnosticTrace Trace
        {
            get
            {
                FxTrace.EnsureEtwProviderInitialized();
                return FxTrace.diagnosticTrace;
            }
        }

        public static bool TracingEnabled
        {
            get
            {
                return FxTrace.tracingEnabled;
            }
        }

        static FxTrace()
        {
            FxTrace.lockObject = new object();
            FxTrace.tracingEnabled = true;
            FxTrace.shouldTraceVerbose = true;
            FxTrace.shouldTraceInformation = true;
            FxTrace.shouldTraceWarning = true;
            FxTrace.shouldTraceError = true;
            FxTrace.shouldTraceCritical = true;
            FxTrace.shouldTraceVerboseToTraceSource = true;
            FxTrace.shouldTraceInformationToTraceSource = true;
            FxTrace.shouldTraceWarningToTraceSource = true;
            FxTrace.shouldTraceErrorToTraceSource = true;
            FxTrace.shouldTraceCriticalToTraceSource = true;
        }

        private static void EnsureEtwProviderInitialized()
        {
            object obj = null;
            if (FxTrace.diagnosticTrace == null)
            {
                bool flag = false;
                try
                {
                    obj = FxTrace.lockObject;
                    Monitor.Enter(obj, ref flag);
                    if (FxTrace.diagnosticTrace == null)
                    {
                        FxTrace.diagnosticTrace = FxTrace.InitializeTracing();
                    }
                }
                finally
                {
                    if (flag)
                    {
                        Monitor.Exit(obj);
                    }
                }
            }
        }

        [SecuritySafeCritical]
        private static EtwDiagnosticTrace InitializeTracing()
        {
            FxTrace.etwProviderId = EtwDiagnosticTrace.DefaultEtwProviderId;
            EtwDiagnosticTrace etwDiagnosticTrace = new EtwDiagnosticTrace("System.Activities", FxTrace.etwProviderId);
            if (etwDiagnosticTrace.EtwProvider != null)
            {
                EtwDiagnosticTrace etwDiagnosticTrace1 = etwDiagnosticTrace;
                EtwDiagnosticTrace etwDiagnosticTrace2 = etwDiagnosticTrace1;
                Action refreshState = etwDiagnosticTrace1.RefreshState;
                etwDiagnosticTrace2.RefreshState = () => { refreshState(); FxTrace.UpdateLevel(); }; 
            }
            FxTrace.UpdateLevel(etwDiagnosticTrace);
            return etwDiagnosticTrace;
        }

        public static bool IsEventEnabled(int index)
        {
            if (FxTrace.enabledEvents == null)
            {
                return true;
            }
            return FxTrace.enabledEvents[index];
        }

        [SecuritySafeCritical]
        private static void UpdateEnabledEventsList(EtwDiagnosticTrace trace)
        {
            object obj = null;
            bool flag;
            bool flag1;
            bool flag2;
            bool flag3;
            bool flag4;
            bool flag5 = false;
            try
            {
                obj = FxTrace.lockObject;
                Monitor.Enter(obj, ref flag5);
                int level = -1;
                EventDescriptor[] eventDescriptorArray = FxTrace.eventDescriptors;
                if (eventDescriptorArray != null)
                {
                    if (FxTrace.enabledEvents == null)
                    {
                        FxTrace.enabledEvents = new bool[(int)eventDescriptorArray.Length];
                    }
                    for (int i = 0; i < (int)FxTrace.enabledEvents.Length; i++)
                    {
                        EventDescriptor eventDescriptor = eventDescriptorArray[i];
                        bool flag6 = FxTrace.Trace.IsEtwEventEnabled(ref eventDescriptor);
                        FxTrace.enabledEvents[i] = flag6;
                        if (flag6 && !FxTrace.Trace.IsEnd2EndActivityTracingEnabled && FxTrace.end2EndEvents.Contains((ushort)eventDescriptor.EventId))
                        {
                            FxTrace.Trace.SetEnd2EndActivityTracingEnabled(true);
                        }
                        if (flag6 && level < eventDescriptor.Level)
                        {
                            level = eventDescriptor.Level;
                        }
                    }
                    if (FxTrace.shouldTraceCriticalToTraceSource)
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = (!trace.ShouldTraceToEtw(TraceEventLevel.Critical) ? false : level >= 1);
                    }
                    FxTrace.shouldTraceCritical = flag;
                    if (FxTrace.shouldTraceErrorToTraceSource)
                    {
                        flag1 = true;
                    }
                    else
                    {
                        flag1 = (!trace.ShouldTraceToEtw(TraceEventLevel.Error) ? false : level >= 2);
                    }
                    FxTrace.shouldTraceError = flag1;
                    if (FxTrace.shouldTraceWarningToTraceSource)
                    {
                        flag2 = true;
                    }
                    else
                    {
                        flag2 = (!trace.ShouldTraceToEtw(TraceEventLevel.Warning) ? false : level >= 3);
                    }
                    FxTrace.shouldTraceWarning = flag2;
                    if (FxTrace.shouldTraceInformationToTraceSource)
                    {
                        flag3 = true;
                    }
                    else
                    {
                        flag3 = (!trace.ShouldTraceToEtw(TraceEventLevel.Informational) ? false : level >= 4);
                    }
                    FxTrace.shouldTraceInformation = flag3;
                    if (FxTrace.shouldTraceVerboseToTraceSource)
                    {
                        flag4 = true;
                    }
                    else
                    {
                        flag4 = (!trace.ShouldTraceToEtw(TraceEventLevel.Verbose) ? false : level >= 5);
                    }
                    FxTrace.shouldTraceVerbose = flag4;
                }
            }
            finally
            {
                if (flag5)
                {
                    Monitor.Exit(obj);
                }
            }
        }

        [SecuritySafeCritical]
        public static void UpdateEventDefinitions(EventDescriptor[] eventDescriptors, ushort[] end2EndEvents)
        {
            FxTrace.EnsureEtwProviderInitialized();
            FxTrace.eventDescriptors = eventDescriptors;
            FxTrace.end2EndEvents = new SortedSet<ushort>(end2EndEvents);
            FxTrace.UpdateEnabledEventsList(FxTrace.diagnosticTrace);
        }

        private static void UpdateLevel(EtwDiagnosticTrace trace)
        {
            if (trace == null)
            {
                return;
            }
            FxTrace.tracingEnabled = trace.TracingEnabled;
            FxTrace.shouldTraceCriticalToTraceSource = trace.ShouldTraceToTraceSource(TraceEventLevel.Critical);
            FxTrace.shouldTraceErrorToTraceSource = trace.ShouldTraceToTraceSource(TraceEventLevel.Error);
            FxTrace.shouldTraceWarningToTraceSource = trace.ShouldTraceToTraceSource(TraceEventLevel.Warning);
            FxTrace.shouldTraceInformationToTraceSource = trace.ShouldTraceToTraceSource(TraceEventLevel.Informational);
            FxTrace.shouldTraceVerboseToTraceSource = trace.ShouldTraceToTraceSource(TraceEventLevel.Verbose);
            FxTrace.shouldTraceCritical = (FxTrace.shouldTraceCriticalToTraceSource ? true : trace.ShouldTraceToEtw(TraceEventLevel.Critical));
            FxTrace.shouldTraceError = (FxTrace.shouldTraceErrorToTraceSource ? true : trace.ShouldTraceToEtw(TraceEventLevel.Error));
            FxTrace.shouldTraceWarning = (FxTrace.shouldTraceWarningToTraceSource ? true : trace.ShouldTraceToEtw(TraceEventLevel.Warning));
            FxTrace.shouldTraceInformation = (FxTrace.shouldTraceInformationToTraceSource ? true : trace.ShouldTraceToEtw(TraceEventLevel.Informational));
            FxTrace.shouldTraceVerbose = (FxTrace.shouldTraceVerboseToTraceSource ? true : trace.ShouldTraceToEtw(TraceEventLevel.Verbose));
            FxTrace.UpdateEnabledEventsList(trace);
        }

        private static void UpdateLevel()
        {
            FxTrace.UpdateLevel(FxTrace.Trace);
        }
    }
}
