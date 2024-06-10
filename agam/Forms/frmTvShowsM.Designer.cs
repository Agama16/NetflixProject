
namespace agam.Forms
{
    partial class frmTvShowsM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.showsGrid = new System.Windows.Forms.DataGridView();
            this.genre = new System.Windows.Forms.Label();
            this.seasons = new System.Windows.Forms.Label();
            this.ageLimit = new System.Windows.Forms.Label();
            this.releaseDate = new System.Windows.Forms.Label();
            this.producerName = new System.Windows.Forms.Label();
            this.tvShow = new System.Windows.Forms.Label();
            this.releaseDatePick = new System.Windows.Forms.DateTimePicker();
            this.description = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.genreTxt = new System.Windows.Forms.TextBox();
            this.seasonsTxt = new System.Windows.Forms.TextBox();
            this.ageLimitTxt = new System.Windows.Forms.TextBox();
            this.producerTxt = new System.Windows.Forms.TextBox();
            this.tvShowTxt = new System.Windows.Forms.TextBox();
            this.descriptionTxt = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.prevBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.showCode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.showsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // showsGrid
            // 
            this.showsGrid.BackgroundColor = System.Drawing.Color.White;
            this.showsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showsGrid.Location = new System.Drawing.Point(264, 66);
            this.showsGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.showsGrid.Name = "showsGrid";
            this.showsGrid.RowHeadersWidth = 62;
            this.showsGrid.RowTemplate.Height = 28;
            this.showsGrid.Size = new System.Drawing.Size(435, 206);
            this.showsGrid.TabIndex = 0;
            this.showsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // genre
            // 
            this.genre.AutoSize = true;
            this.genre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.genre.Location = new System.Drawing.Point(22, 230);
            this.genre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(36, 13);
            this.genre.TabIndex = 1;
            this.genre.Text = "Genre";
            // 
            // seasons
            // 
            this.seasons.AutoSize = true;
            this.seasons.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.seasons.Location = new System.Drawing.Point(21, 198);
            this.seasons.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.seasons.Name = "seasons";
            this.seasons.Size = new System.Drawing.Size(102, 13);
            this.seasons.TabIndex = 2;
            this.seasons.Text = "Number Of Seasons";
            // 
            // ageLimit
            // 
            this.ageLimit.AutoSize = true;
            this.ageLimit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ageLimit.Location = new System.Drawing.Point(22, 167);
            this.ageLimit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ageLimit.Name = "ageLimit";
            this.ageLimit.Size = new System.Drawing.Size(50, 13);
            this.ageLimit.TabIndex = 3;
            this.ageLimit.Text = "Age Limit";
            // 
            // releaseDate
            // 
            this.releaseDate.AutoSize = true;
            this.releaseDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.releaseDate.Location = new System.Drawing.Point(21, 108);
            this.releaseDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.releaseDate.Name = "releaseDate";
            this.releaseDate.Size = new System.Drawing.Size(72, 13);
            this.releaseDate.TabIndex = 4;
            this.releaseDate.Text = "Release Date";
            // 
            // producerName
            // 
            this.producerName.AutoSize = true;
            this.producerName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.producerName.Location = new System.Drawing.Point(22, 139);
            this.producerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.producerName.Name = "producerName";
            this.producerName.Size = new System.Drawing.Size(81, 13);
            this.producerName.TabIndex = 5;
            this.producerName.Text = "Producer Name";
            // 
            // tvShow
            // 
            this.tvShow.AutoSize = true;
            this.tvShow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tvShow.Location = new System.Drawing.Point(21, 77);
            this.tvShow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tvShow.Name = "tvShow";
            this.tvShow.Size = new System.Drawing.Size(82, 13);
            this.tvShow.TabIndex = 6;
            this.tvShow.Text = "TV Show Name";
            // 
            // releaseDatePick
            // 
            this.releaseDatePick.Location = new System.Drawing.Point(127, 103);
            this.releaseDatePick.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.releaseDatePick.Name = "releaseDatePick";
            this.releaseDatePick.Size = new System.Drawing.Size(123, 20);
            this.releaseDatePick.TabIndex = 7;
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.description.Location = new System.Drawing.Point(21, 259);
            this.description.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(58, 13);
            this.description.TabIndex = 8;
            this.description.Text = "description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // genreTxt
            // 
            this.genreTxt.Location = new System.Drawing.Point(127, 223);
            this.genreTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.genreTxt.Name = "genreTxt";
            this.genreTxt.Size = new System.Drawing.Size(68, 20);
            this.genreTxt.TabIndex = 10;
            // 
            // seasonsTxt
            // 
            this.seasonsTxt.Location = new System.Drawing.Point(127, 195);
            this.seasonsTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.seasonsTxt.Name = "seasonsTxt";
            this.seasonsTxt.Size = new System.Drawing.Size(68, 20);
            this.seasonsTxt.TabIndex = 11;
            // 
            // ageLimitTxt
            // 
            this.ageLimitTxt.Location = new System.Drawing.Point(127, 164);
            this.ageLimitTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ageLimitTxt.Name = "ageLimitTxt";
            this.ageLimitTxt.Size = new System.Drawing.Size(68, 20);
            this.ageLimitTxt.TabIndex = 12;
            // 
            // producerTxt
            // 
            this.producerTxt.Location = new System.Drawing.Point(127, 132);
            this.producerTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.producerTxt.Name = "producerTxt";
            this.producerTxt.Size = new System.Drawing.Size(68, 20);
            this.producerTxt.TabIndex = 13;
            // 
            // tvShowTxt
            // 
            this.tvShowTxt.Location = new System.Drawing.Point(127, 70);
            this.tvShowTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tvShowTxt.Name = "tvShowTxt";
            this.tvShowTxt.Size = new System.Drawing.Size(68, 20);
            this.tvShowTxt.TabIndex = 14;
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.Location = new System.Drawing.Point(127, 256);
            this.descriptionTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.Size = new System.Drawing.Size(68, 20);
            this.descriptionTxt.TabIndex = 15;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Black;
            this.addBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addBtn.Location = new System.Drawing.Point(367, 283);
            this.addBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(91, 27);
            this.addBtn.TabIndex = 16;
            this.addBtn.Text = "Save";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.Black;
            this.clearBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clearBtn.Location = new System.Drawing.Point(264, 283);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(99, 27);
            this.clearBtn.TabIndex = 25;
            this.clearBtn.Text = "Add New";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.Black;
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.Location = new System.Drawing.Point(461, 283);
            this.editBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(93, 27);
            this.editBtn.TabIndex = 27;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // prevBtn
            // 
            this.prevBtn.BackColor = System.Drawing.Color.Black;
            this.prevBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.prevBtn.Location = new System.Drawing.Point(24, 329);
            this.prevBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(88, 29);
            this.prevBtn.TabIndex = 29;
            this.prevBtn.Text = "prev";
            this.prevBtn.UseVisualStyleBackColor = false;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.Color.Black;
            this.nextBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nextBtn.Location = new System.Drawing.Point(765, 323);
            this.nextBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(85, 29);
            this.nextBtn.TabIndex = 30;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(-10, -6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(891, 47);
            this.button1.TabIndex = 31;
            this.button1.Text = "TV Shows";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Black;
            this.backBtn.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.backBtn.Location = new System.Drawing.Point(367, 315);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(129, 43);
            this.backBtn.TabIndex = 35;
            this.backBtn.Text = "back to main";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Show code";
            // 
            // showCode
            // 
            this.showCode.Location = new System.Drawing.Point(127, 287);
            this.showCode.Name = "showCode";
            this.showCode.Size = new System.Drawing.Size(68, 20);
            this.showCode.TabIndex = 37;
            // 
            // frmTvShowsM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::agam.Properties.Resources.netflix;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(861, 441);
            this.Controls.Add(this.showCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.prevBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.descriptionTxt);
            this.Controls.Add(this.tvShowTxt);
            this.Controls.Add(this.producerTxt);
            this.Controls.Add(this.ageLimitTxt);
            this.Controls.Add(this.seasonsTxt);
            this.Controls.Add(this.genreTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.description);
            this.Controls.Add(this.releaseDatePick);
            this.Controls.Add(this.tvShow);
            this.Controls.Add(this.producerName);
            this.Controls.Add(this.releaseDate);
            this.Controls.Add(this.ageLimit);
            this.Controls.Add(this.seasons);
            this.Controls.Add(this.genre);
            this.Controls.Add(this.showsGrid);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmTvShowsM";
            this.Text = "TvShowsM";
            this.Load += new System.EventHandler(this.frmTvShowsM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView showsGrid;
        private System.Windows.Forms.Label genre;
        private System.Windows.Forms.Label seasons;
        private System.Windows.Forms.Label ageLimit;
        private System.Windows.Forms.Label releaseDate;
        private System.Windows.Forms.Label producerName;
        private System.Windows.Forms.Label tvShow;
        private System.Windows.Forms.DateTimePicker releaseDatePick;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox genreTxt;
        private System.Windows.Forms.TextBox seasonsTxt;
        private System.Windows.Forms.TextBox ageLimitTxt;
        private System.Windows.Forms.TextBox producerTxt;
        private System.Windows.Forms.TextBox tvShowTxt;
        private System.Windows.Forms.TextBox descriptionTxt;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button prevBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.TextBox showCode;
        private System.Windows.Forms.Label label1;
    }
}