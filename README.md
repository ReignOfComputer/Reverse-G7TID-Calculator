# Reverse G7TID Calculator

Pokemon Sun/Moon (Gen 7) has a different way of calculating Trainer ID (G7TID).

It still has a Trainer ID (TID) and Secret ID (SID), which form together using:
`G7TID = TID + (SID * 65536) % 1000000`

This application calculates TID and SID based on the preferred G7TID. Since there are many possibilities of TID/SID, the starting TID is randomized so a different variant is returned each search.

Special thanks to @PP-theSLAYER and @SciresM.