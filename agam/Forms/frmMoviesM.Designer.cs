
namespace agam.Forms
{
    partial class frmMoviesM
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
            this.moviesGrid = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.description = new System.Windows.Forms.Label();
            this.ageLimit = new System.Windows.Forms.Label();
            this.genre = new System.Windows.Forms.Label();
            this.releaseDate = new System.Windows.Forms.Label();
            this.producer = new System.Windows.Forms.Label();
            this.movieName = new System.Windows.Forms.Label();
            this.releasePick = new System.Windows.Forms.DateTimePicker();
            this.producerTxt = new System.Windows.Forms.TextBox();
            this.movieTxt = new System.Windows.Forms.TextBox();
            this.genreTxt = new System.Windows.Forms.TextBox();
            this.ageLimitTxt = new System.Windows.Forms.TextBox();
            this.descriptionTxt = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.prevBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.movieCode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.moviesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // moviesGrid
            // 
            this.moviesGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.moviesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.moviesGrid.Location = new System.Drawing.Point(222, 60);
            this.moviesGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.moviesGrid.Name = "moviesGrid";
            this.moviesGrid.RowHeadersWidth = 62;
            this.moviesGrid.RowTemplate.Height = 28;
            this.moviesGrid.Size = new System.Drawing.Size(443, 238);
            this.moviesGrid.TabIndex = 0;
            this.moviesGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.moviesGrid_CellContentClick);
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.description.Location = new System.Drawing.Point(8, 266);
            this.description.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(60, 13);
            this.description.TabIndex = 1;
            this.description.Text = "Description";
            // 
            // ageLimit
            // 
            this.ageLimit.AutoSize = true;
            this.ageLimit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ageLimit.Location = new System.Drawing.Point(8, 228);
            this.ageLimit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ageLimit.Name = "ageLimit";
            this.ageLimit.Size = new System.Drawing.Size(50, 13);
            this.ageLimit.TabIndex = 2;
            this.ageLimit.Text = "Age Limit";
            // 
            // genre
            // 
            this.genre.AutoSize = true;
            this.genre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.genre.Location = new System.Drawing.Point(8, 191);
            this.genre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(36, 13);
            this.genre.TabIndex = 3;
            this.genre.Text = "Genre";
            // 
            // releaseDate
            // 
            this.releaseDate.AutoSize = true;
            this.releaseDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.releaseDate.Location = new System.Drawing.Point(8, 153);
            this.releaseDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.releaseDate.Name = "releaseDate";
            this.releaseDate.Size = new System.Drawing.Size(72, 13);
            this.releaseDate.TabIndex = 4;
            this.releaseDate.Text = "Release Date";
            // 
            // producer
            // 
            this.producer.AutoSize = true;
            this.producer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.producer.Location = new System.Drawing.Point(8, 111);
            this.producer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.producer.Name = "producer";
            this.producer.Size = new System.Drawing.Size(81, 13);
            this.producer.TabIndex = 5;
            this.producer.Text = "Producer Name";
            this.producer.Click += new System.EventHandler(this.label5_Click);
            // 
            // movieName
            // 
            this.movieName.AutoSize = true;
            this.movieName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.movieName.Location = new System.Drawing.Point(13, 75);
            this.movieName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.movieName.Name = "movieName";
            this.movieName.Size = new System.Drawing.Size(67, 13);
            this.movieName.TabIndex = 6;
            this.movieName.Text = "Movie Name";
            // 
            // releasePick
            // 
            this.releasePick.Location = new System.Drawing.Point(85, 153);
            this.releasePick.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.releasePick.Name = "releasePick";
            this.releasePick.Size = new System.Drawing.Size(135, 20);
            this.releasePick.TabIndex = 7;
            // 
            // producerTxt
            // 
            this.producerTxt.Location = new System.Drawing.Point(91, 111);
            this.producerTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.producerTxt.Name = "producerTxt";
            this.producerTxt.Size = new System.Drawing.Size(68, 20);
            this.producerTxt.TabIndex = 8;
            // 
            // movieTxt
            // 
            this.movieTxt.Location = new System.Drawing.Point(91, 71);
            this.movieTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.movieTxt.Name = "movieTxt";
            this.movieTxt.Size = new System.Drawing.Size(68, 20);
            this.movieTxt.TabIndex = 9;
            // 
            // genreTxt
            // 
            this.genreTxt.Location = new System.Drawing.Point(91, 191);
            this.genreTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.genreTxt.Name = "genreTxt";
            this.genreTxt.Size = new System.Drawing.Size(68, 20);
            this.genreTxt.TabIndex = 10;
            // 
            // ageLimitTxt
            // 
            this.ageLimitTxt.Location = new System.Drawing.Point(91, 228);
            this.ageLimitTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ageLimitTxt.Name = "ageLimitTxt";
            this.ageLimitTxt.Size = new System.Drawing.Size(68, 20);
            this.ageLimitTxt.TabIndex = 11;
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.Location = new System.Drawing.Point(91, 259);
            this.descriptionTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.Size = new System.Drawing.Size(68, 20);
            this.descriptionTxt.TabIndex = 12;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Black;
            this.addBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addBtn.Location = new System.Drawing.Point(327, 300);
            this.addBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(95, 28);
            this.addBtn.TabIndex = 20;
            this.addBtn.Text = "Save";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.Black;
            this.clearBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clearBtn.Location = new System.Drawing.Point(222, 300);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(101, 29);
            this.clearBtn.TabIndex = 25;
            this.clearBtn.Text = "Add new";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.Black;
            this.editBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.editBtn.Location = new System.Drawing.Point(426, 300);
            this.editBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(89, 28);
            this.editBtn.TabIndex = 27;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = false;
            // 
            // prevBtn
            // 
            this.prevBtn.BackColor = System.Drawing.Color.Black;
            this.prevBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.prevBtn.Location = new System.Drawing.Point(16, 332);
            this.prevBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(97, 30);
            this.prevBtn.TabIndex = 28;
            this.prevBtn.Text = "prev";
            this.prevBtn.UseVisualStyleBackColor = false;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(-23, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(768, 47);
            this.button1.TabIndex = 30;
            this.button1.Text = "Movies";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.Color.Black;
            this.nextBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nextBtn.Location = new System.Drawing.Point(639, 302);
            this.nextBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(85, 28);
            this.nextBtn.TabIndex = 31;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Black;
            this.backBtn.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.backBtn.Location = new System.Drawing.Point(327, 332);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(123, 43);
            this.backBtn.TabIndex = 35;
            this.backBtn.Text = "back to main";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Movie Code";
            // 
            // movieCode
            // 
            this.movieCode.Location = new System.Drawing.Point(91, 293);
            this.movieCode.Name = "movieCode";
            this.movieCode.Size = new System.Drawing.Size(68, 20);
            this.movieCode.TabIndex = 37;
            // 
            // frmMoviesM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::agam.Properties.Resources.netflix;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(732, 435);
            this.Controls.Add(this.movieCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.prevBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.descriptionTxt);
            this.Controls.Add(this.ageLimitTxt);
            this.Controls.Add(this.genreTxt);
            this.Controls.Add(this.movieTxt);
            this.Controls.Add(this.producerTxt);
            this.Controls.Add(this.releasePick);
            this.Controls.Add(this.movieName);
            this.Controls.Add(this.producer);
            this.Controls.Add(this.releaseDate);
            this.Controls.Add(this.genre);
            this.Controls.Add(this.ageLimit);
            this.Controls.Add(this.description);
            this.Controls.Add(this.moviesGrid);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMoviesM";
            this.Text = "frmMoviesM";
            this.Load += new System.EventHandler(this.frmMoviesM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.moviesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView moviesGrid;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label ageLimit;
        private System.Windows.Forms.Label genre;
        private System.Windows.Forms.Label releaseDate;
        private System.Windows.Forms.Label producer;
        private System.Windows.Forms.Label movieName;
        private System.Windows.Forms.DateTimePicker releasePick;
        private System.Windows.Forms.TextBox producerTxt;
        private System.Windows.Forms.TextBox movieTxt;
        private System.Windows.Forms.TextBox genreTxt;
        private System.Windows.Forms.TextBox ageLimitTxt;
        private System.Windows.Forms.TextBox descriptionTxt;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button prevBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.TextBox movieCode;
        private System.Windows.Forms.Label label1;
    }
}