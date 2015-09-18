﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MW5.Shared.Log;
using MW5.Tools.Model.Layers;
using MW5.Tools.Model.Parameters;
using MW5.Tools.Model.Parameters.Layers;

namespace MW5.Tools.Helpers
{
    /// <summary>
    /// Extension method to work with input layer / datasource input parameters.
    /// </summary>
    internal static class InputHelper
    {
        /// <summary>
        /// Sets callback to the input datasource to provide IStopExecution implementation
        /// for MapWinGIS methods.
        /// </summary>
        public static void SetCallbackToInputs(this IEnumerable<BaseParameter> parameters, IApplicationCallback callback)
        {
            foreach (var p in parameters.OfType<LayerParameterBase>())
            {
                var ds = p.Datasource;
                if (ds != null)
                {
                    ds.Callback = callback;
                }
            }
        }

        /// <summary>
        /// Closes the input datasources.
        /// </summary>
        public static void CloseInputDatasources(this IEnumerable<BaseParameter> parameters)
        {
            foreach (var p in parameters.OfType<LayerParameterBase>())
            {
                var info = p.Value as IDatasourceInput;
                if (info != null)
                {
                    p.ClosedPointer = info.Pointer;
                    info.Close();
                }
            }
        }
    }
}
