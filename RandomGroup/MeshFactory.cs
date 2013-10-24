﻿using TgcViewer;
using Microsoft.DirectX.Direct3D;
using Microsoft.DirectX;

namespace AlumnoEjemplos.RandomGroup
{
    public class MeshFactory
    {
        public static MeshPropio getMesh(string meshPath)
        {
            Device device = GuiController.Instance.D3dDevice;

            MeshPropio newMesh = null;
            if (meshPath.EndsWith(".xml")) newMesh = new XMLMesh(meshPath);
            newMesh.setPosition(new Vector3(50, 50, 50));
            return newMesh;
        }
        public static MeshPropio getMesh(string meshPath, string texturePath)
        {
            Device device = GuiController.Instance.D3dDevice;

            MeshPropio newMesh = null;
            if (meshPath.EndsWith(".x")) newMesh = new XMesh(meshPath, texturePath);
            if (meshPath.EndsWith(".xml")) newMesh = new XMLMesh(meshPath);
            newMesh.setPosition(new Vector3(50, 50, 50));
            return newMesh;
        }
        
    }
}