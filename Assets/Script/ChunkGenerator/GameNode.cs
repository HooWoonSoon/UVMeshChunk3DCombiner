public class GameNode
{
    public Chunk chunk;
    public int x, y, z; //  Basically to represent the local position of the node in the chunk
    public int worldX, worldY, worldZ;
    public int tileID;

    public bool isWalkable;

    public GameNode(Chunk chunk, int x, int y, int z, int tileID, bool isWalkable)
    {
        this.chunk = chunk;
        this.x = x;
        this.y = y;
        this.z = z;
        this.tileID = tileID;
        this.isWalkable = isWalkable;

        worldX = x + chunk.startPoint.x;
        worldY = y + chunk.startPoint.y;
        worldZ = z + chunk.startPoint.z;
    }
}
