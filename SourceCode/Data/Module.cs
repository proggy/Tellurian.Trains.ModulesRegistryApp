﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ModulesRegistry.Data
{
    public partial class Module
    {
        public Module()
        {
            ModuleOwnerships = new HashSet<ModuleOwnership>();
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public int ScaleId { get; set; }
        public int StandardId { get; set; }
        public string Theme { get; set; }
        public short? RepresentsFromYear { get; set; }
        public short? RepresentsUptoYear { get; set; }
        public double? Radius { get; set; }
        public double? Angle { get; set; }
        public double Length { get; set; }
        public short NumberOfThroughTracks { get; set; }
        public bool HasNormalGauge { get; set; }
        public bool HasNarrowGauge { get; set; }
        public bool Is2R { get; set; }
        public bool Is3R { get; set; }
        public bool IsSignal { get; set; }
        public bool IsTurntable { get; set; }
        public bool IsDuckunder { get; set; }
        public bool IsJunction { get; set; }
        public bool IsStation { get; set; }
        public ModuleFunctionalState FunctionalState { get; set; }
        public ModuleLandscapeState LandscapeState { get; set; }
        public byte[] DxfDrawing { get; set; }
        public byte[] PdfDocumentation { get; set; }
        public string Note { get; set; }
        public int? StationId { get; set; }
        public int? FREMONumber { get; set; }


        public virtual Scale Scale { get; set; }
        public virtual ModuleStandard Standard { get; set; }
        public virtual Station Station { get; set; }
        public virtual ICollection<ModuleOwnership> ModuleOwnerships { get; set; }
    }
}
