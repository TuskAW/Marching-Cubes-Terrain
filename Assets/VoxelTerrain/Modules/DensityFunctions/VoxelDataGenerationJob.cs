﻿using Unity.Jobs;
using Unity.Mathematics;

namespace Eldemarkki.VoxelTerrain.Density
{
    public interface VoxelDataGenerationJob : IJobParallelFor
    {
        int3 WorldPositionOffset { get; set; }
        DensityVolume OutputVoxelData { get; set; }
    }
}