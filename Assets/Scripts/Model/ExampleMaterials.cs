﻿using System;

public partial class MaterialSample
{
	public static MaterialSample ElastofoamI_133;
	public static MaterialSample UltradurB_4300;

	static MaterialSample() 
	{
		ElastofoamI_133 = new FoamMaterial() 
		{
			Family = "Elastoform",
			SubFamily = "I",
			MaterialCode = "4510/133/S",
			ElasticModulus = 7.6,
			Density = 524,
			TensileStrength = 4543,
			ElongationAtRupture = 164
		};

		UltradurB_4300 = new TechnicalPlasticMaterial () 
		{
			Family = "Ultradur",
			SubFamily = "B 4300 G10",
			MaterialCode = "PBT-GF50",
			ElasticModulus = 16500,
			Density = 1730,
			TensileStrength = 160000,
			ElongationAtRupture = 1.7
		};	
	}
}
