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

singleton Material(AlienSky)
{
   mapTo = "unmapped_mat";
   cubemap = "AlienSkyCubemap";
   castShadows = "0";
   showFootprints = "0";
   diffuseColor[0] = "0.258824 0.32549 0.427451 1";
};

new CubemapData(AlienSkyCubemap)
{
   cubeFace[0] = "art/skies/Alien_Sky/GoldenHourCloudySky_1.dds";
   cubeFace[1] = "art/skies/Alien_Sky/GoldenHourCloudySky_2.dds";
   cubeFace[2] = "art/skies/Alien_Sky/GoldenHourCloudySky_3.dds";
   cubeFace[3] = "art/skies/Alien_Sky/GoldenHourCloudySky_4.dds";
   cubeFace[4] = "art/skies/Alien_Sky/GoldenHourCloudySky_5.dds";
   cubeFace[5] = "art/skies/Alien_Sky/GoldenHourCloudySky_6.dds";
};
