﻿using System;
using System.Collections.Generic;

using Grasshopper.Kernel;
using Rhino.Geometry;

namespace termitesABMS_toolkitAlpha_r5.basicTermiteGeometry
{
    public class GHC_displayPyramid : GH_Component
    {
        /// <summary>
        /// Initializes a new instance of the GHC_displayPyramid class.
        /// </summary>
        public GHC_displayPyramid()
          : base("GHC_displayPyramid", "disp Pyramid",
              "A component to diplay a Pyramid",
              "Termites", "5 | Utilities")
        {
        }
        /// <summary>
        /// Registers all the input parameters for this component.
        /// </summary>
        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {
            pManager.AddGenericParameter("Pyramid", "Pyramid", "Pyramid", GH_ParamAccess.item);
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
        {
            pManager.AddCurveParameter("Display", "Display", "Display", GH_ParamAccess.list);
        }

        /// <summary>
        /// This is the method that actually does the work.
        /// </summary>
        /// <param name="DA">The DA object is used to retrieve from inputs and store in outputs.</param>
        protected override void SolveInstance(IGH_DataAccess DA)
        {
            Pyramid iPyramid = null;
            DA.GetData("Pyramid", ref iPyramid);
            DA.SetDataList("Display", iPyramid.ComputeDisplayLines());
        }

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        protected override System.Drawing.Bitmap Icon
        {
            get
            {
                //You can add image files to your project resources and access them like this:
                // return Resources.IconForThisComponent;
                return null;
            }
        }

        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid
        {
            get { return new Guid("b99b095f-b2e1-4271-8971-8ec5e6b8215c"); }
        }
    }
}