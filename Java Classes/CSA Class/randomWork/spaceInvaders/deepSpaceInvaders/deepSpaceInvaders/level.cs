using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deepSpaceInvaders
{
    public partial class level : Form
    {
        //global vars
        private static bool moveLeft, moveRight, enemyRight = true, enemyLeft, gameOver = false, isPressed, killedAll;
        //array of enemy pictures
        public static PictureBox[,] enemy = new PictureBox[4, 11];
        private static int numKilled = 0, enemySpeed, timesWon = 1;
        public static int score;
        private const int PLAYER_SPEED = 5, ENEMY_NUM = 44, HATCH_SPEED = 4;

        public level()
        {
            InitializeComponent();
        }

        //happens when form loads
        private void level_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            enemies();
            enemySpeed = timesWon * 100;
            numKilled = 0;
            killedAll = false;
            gameOver = false;
        }

        //main game timer
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            lblScore.Text = "Score: " + score;
            stopGame();
            checkBounds();
            movePlayer();
            moveBulletEnemy();
            moveEnemies();
            moveBullet();
            moveDown();
            killEnemy();
            endGame();
        }

        //handles enemy shooting on a seperate timer because main timer is too fast
        private void shootTimer_Tick(object sender, EventArgs e)
        {
            enemyShoot();
        }

        //spawns enemies
        private void enemies()
        {
            int previousX = 53, previousY = 12;
            for (int z = 0; z < 4; z++)
            {
                previousY += 56;
                previousX = 53;
                for (int x = 0; x < 11; x++)
                {
                    enemy[z, x] = new PictureBox();
                    enemy[z, x].Image = Properties.Resources.First_Ball_50;
                    enemy[z, x].Location = new Point(previousX, previousY);
                    enemy[z, x].Tag = "enemy";
                    previousX += 56;
                    enemy[z, x].Size = new Size(50, 50);
                    this.Controls.Add(enemy[z, x]);
                    enemy[z, x].BringToFront();
                }
            }
        }

        //WIP... makes enemies shoot back (dead enemies shoot)
        private void enemyShoot()
        {
            Random rand = new Random();
            int randomX = rand.Next(0, 10);
            int randomY = rand.Next(0, 3);
            //lblScore.Text = useRandom.ToString();
            PictureBox bulletEnemy = new PictureBox();
            bulletEnemy.Image = Properties.Resources.hatch_bullet;
            bulletEnemy.Size = new Size(16, 16);
            bulletEnemy.Tag = "hatch_enemy";
            //puts bullet right in middle of the ball
            bulletEnemy.Left = enemy[randomY, randomX].Left + 25;
            bulletEnemy.Top = enemy[randomY, randomX].Top - 25;
            this.Controls.Add(bulletEnemy);
            bulletEnemy.BringToFront();
        }

        //moves the enemy bullets
        private void moveBulletEnemy()
        {
            foreach (Control x in this.Controls)
            {
                if (x.Tag == "hatch_enemy")
                {
                    x.Top += HATCH_SPEED;
                }
                if (x.Top > 600)
                    x.Dispose();
            }
        }

        private void playerTimer_Tick(object sender, EventArgs e)
        {

        }

        //moves player picture
        private void movePlayer()
        {
            if (moveRight)
                playerPictureBox.Left += PLAYER_SPEED;
            else if (moveLeft)
                playerPictureBox.Left -= PLAYER_SPEED;
        }

        //checks if key is pressed
        private void keyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                moveLeft = true;
            if (e.KeyCode == Keys.Right)
                moveRight = true;
            if(e.KeyCode == Keys.Space && !isPressed)
            {
                isPressed = true;
                makeBullet();
            }
        }

        //checks if key is up
        private void keyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                moveLeft = false;
            if (e.KeyCode == Keys.Right)
                moveRight = false;
            if (isPressed)
                isPressed = false;
        }

        //moves enemies side and down
        private void moveEnemies()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "enemy")
                {
                    if (enemyRight)
                    {
                        x.Left += enemySpeed;
                    }
                    else if (enemyLeft)
                    {
                        x.Left -= enemySpeed;
                    }
                }
            }
        }

        //shifts enemies down
        private void moveDown()
        {
            foreach(Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "enemy")
                {
                    if (x.Right >= 785)
                    {
                        foreach (Control ball in this.Controls)
                        {
                            if (ball.Tag == "enemy")
                                ball.Top += 10;
                        }
                    }
                }
            }
        }

        //checks to see if enemy has been shot
        private void killEnemy()
        {
            foreach(Control x in this.Controls)
            {
                //x is ball, z is hatch(bullet)
                foreach (Control z in this.Controls)
                {
                    if(z.Tag == "hatch" && x.Tag == "enemy")
                    {
                        if (z.Bounds.IntersectsWith(x.Bounds))
                        {
                            x.Dispose();
                            z.Dispose();
                            numKilled++;
                            score += 20;
                            lblKills.Text = "Kills: " + numKilled + "/44";
                            if (numKilled >= ENEMY_NUM)
                            {
                                endGame();
                                killedAll = true;
                            }
                        }
                    }
                }
            }
        }

        //checks to see if the balls are touching the player, gone too far, or if player gets shot.
        private void stopGame()
        {
            foreach (Control x in this.Controls)
                {
                    if (x is PictureBox && x.Bounds.IntersectsWith(playerPictureBox.Bounds) && x.Tag == "enemy")
                    {
                        gameOver = true;
                    }
                    else if (x is PictureBox && x.Tag == "enemy" && x.Bottom >= 450)
                    {
                    gameOver = true;
                    }
                    else if(x is PictureBox && x.Tag == "hatch_enemy" && x.Bounds.IntersectsWith(playerPictureBox.Bounds)){
                    gameOver = true;
                    }
                }
        }

        //creates bullet for shooter
        private void makeBullet()
        {
            PictureBox bullet = new PictureBox();
            bullet.Image = Properties.Resources.hatch_bullet;
            bullet.Size = new Size(16, 16);
            bullet.Tag = "hatch";
            bullet.Left = playerPictureBox.Left + 15;
            bullet.Top = playerPictureBox.Top - 20;
            this.Controls.Add(bullet);
            bullet.BringToFront();
        }

        //moves player bullet
        private void moveBullet()
        {
            foreach (Control x in this.Controls)
            {
                if(x.Tag == "hatch")
                {
                    x.Top -= HATCH_SPEED;
                }
                if (x.Top < 0)
                    x.Dispose();
            }
        }

        //checks to see if any element is out of window
        private void checkBounds()
        {
            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && x.Tag == "enemy")
                {
                    if (x.Right >= 785)
                    {
                        enemyRight = false;
                        enemyLeft = true;
                    }
                    else if (x.Left <= 0)
                    {
                        enemyRight = true;
                        enemyLeft = false;
                    }
                }
            }
            if(playerPictureBox.Right >= 785)
            {
                playerPictureBox.Left -= PLAYER_SPEED;
            }
            if (playerPictureBox.Left <= 0)
            {
                playerPictureBox.Left += PLAYER_SPEED;
            }
        }

        //happens after game is won or lost
        private void endGame()
        {
            if (gameOver)
            {
                score = 0;
                timesWon = 1;
                gameTimer.Stop();
                Close();
                Thread.Sleep(500);
                optionMenu options = new optionMenu();
                options.ShowDialog();
                gameOver = false;
                killedAll = false;
            }
            else if (killedAll)
            {
                Close();
                timesWon++;
                gameTimer.Stop();
                level newLevel = new level();
                newLevel.ShowDialog();
            }
        }
    }
}
