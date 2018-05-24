
cd C:...\MorningTests

setlocal enableextensions
set name=%DATE:/=_%
mkdir %name%

move  "C:...\MobbySlotsTest\bin\Debug\Mobbyslots.log" "%name%"
move  "C:...\AnyDayCasinoTest\bin\Debug\Anydaycasino.log" "%name%"
move  "C:...\UkCasinoGamesTest\bin\Debug\UkCasinoGames.log" "%name%"
move  "C:...\SlotsRitchesTest\bin\Debug\SlotsRitches.log" "%name%"
move  "C:...\MobJackPotTest\bin\Debug\Mobjackpot.log" "%name%"
move  "C:...\Games\bin\Debug\Games.log" "%name%"


pause