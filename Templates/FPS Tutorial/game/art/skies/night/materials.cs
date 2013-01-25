//-----------------------------------------------------------------------------
// Copyright (c) 2012 GarageGames, LLC
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to
// deal in the Software without restriction, including without limitation the
// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
// sell copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
// IN THE SOFTWARE.
//-----------------------------------------------------------------------------

singleton CubemapData( CTNightSkyCubemap )
{
   cubeFace[0] = "art/skies/night/ct_night_skybox_3.dds";
   cubeFace[1] = "art/skies/night/ct_night_skybox_4.dds";
   cubeFace[2] = "art/skies/night/ct_night_skybox_2.dds";
   cubeFace[3] = "art/skies/night/ct_night_skybox_1.dds";
   cubeFace[4] = "art/skies/night/ct_night_skybox_5.dds";
   cubeFace[5] = "art/skies/night/ct_night_skybox_6.dds";
};

singleton Material( CTnightTime )
{
   cubemap = CTNightSkyCubemap;
   materialTag0 = "RoadAndPath";
   constantCubemapGloss = "0.2";
};

singleton Material(Moonmat)
{
	diffuseMap[0] = "art/skies/night/moon_wglow.png";

	diffuseColor[0] = "0.439216 0.439216 0.439216 1";
	specular[0] = "1 1 1 1";
	specularPower[0] = 211;
	pixelSpecular[0] = 1;
	emissive[0] = 1;

	doubleSided = 1;
	translucent = true;
	translucentBlendOp = "LerpAlpha";
   colorMultiply[0] = "";
   castShadows = false;
   materialTag0 = "RoadAndPath";
   constantCubemapGloss = "0.2";
};

