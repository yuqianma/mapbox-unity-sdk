﻿namespace Mapbox.Unity.Map
{
	using System;


	[Serializable]
	public class UnifiedMapOptions
	{
		public MapPresetType mapPreset = MapPresetType.LocationBasedMap;
		public MapOptions mapOptions = new MapOptions();
		public ImageryLayerProperties imageryLayerProperties = new ImageryLayerProperties();
		public ElevationLayerProperties elevationLayerProperties = new ElevationLayerProperties();
		public VectorLayerProperties vectorLayerProperties = new VectorLayerProperties();
	}
}
