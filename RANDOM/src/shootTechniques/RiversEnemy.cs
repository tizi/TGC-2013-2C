﻿using System;
using System.Collections.Generic;
using AlumnoEjemplos.RANDOM.src.meshUtils;
using Microsoft.DirectX;
using TgcViewer;

namespace AlumnoEjemplos.RANDOM.src.shootTechniques
{
    public class RiversEnemy : ShootTechnique
    {
        private Random rand = new Random();
        public RiversEnemy() 
        { 
            timeBetweenShoots = 100;
            bulletDrawing = MeshFactory.getMesh(GuiController.Instance.AlumnoEjemplosMediaDir + 
                "Random\\Meshes\\Weapons\\Pez.xml").scale(new Vector3(0.08f, 0.08f, 0.08f));
        }
        public override void getRealShoot(List<Projectile> tmpList)
        {
            initDir.Normalize();
            initDir.Add(new Vector3((-1 + (float)rand.NextDouble() * 2) / 20, (-1 + (float)rand.NextDouble() * 2) / 20, (-1 + (float)rand.NextDouble() * 2) / 20));//Una direccion al azar para cada bala
            initDir.Scale((float)GuiController.Instance.Modifiers["Velocidad"]);

            tmpList.Add(new Projectile(initPos, bulletDrawing.clone(), initDir));
        }

        public override string ToString() { return "River's Enemy"; }
    }
}
