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

//----------------------------------------------------------------------------
// Game start / end events sent from the server
//----------------------------------------------------------------------------

function clientCmdGameStart(%seq)
{
   PlayerListGui-->gameRules.setText("First to 20 frags wins the game!");  // @todo: this should come from the server
   PlayerListGui.zeroScores();
   PlayerListGui-->timeRemainingPanel.setVisible(true);
   
}

// Used to update loading text to see how many players are ready to start
// The mission.
function clientCmdUpdateLoadingText(%text)
{
   LoadingProgressTxt.setValue(%text);
}
function clientCmdWaitingForPlayers(%text)
{
   // We display the disconnect button when waiting for players to join
   if ( isObject( LoadingGui ) )
      LoadingGui.showDisconnectButton();
}

function clientCmdGameEnd(%endGamePause)
{
   // Stop local activity... the game will be destroyed on the server
   sfxStopAll();
   
   if ((!EditorIsActive() && !GuiEditorIsActive()))
   {
      // Show final scores
      PlayerListGui.showFinalScores();
   
      // Go back to the main menu after pausing amount.
      //schedule(%endGamePause * 1000, 0, "disconnect");
   }
   
}
