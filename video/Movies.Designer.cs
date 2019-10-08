namespace video
{
    partial class Movies
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
            this.genre_label = new System.Windows.Forms.Label();
            this.plot_label = new System.Windows.Forms.Label();
            this.copies_label = new System.Windows.Forms.Label();
            this.rentalcost_label = new System.Windows.Forms.Label();
            this.year_label = new System.Windows.Forms.Label();
            this.title_label = new System.Windows.Forms.Label();
            this.rating_label = new System.Windows.Forms.Label();
            this.genre_text = new System.Windows.Forms.TextBox();
            this.plot_text = new System.Windows.Forms.TextBox();
            this.copies_text = new System.Windows.Forms.TextBox();
            this.rentalcost_text = new System.Windows.Forms.TextBox();
            this.year_text = new System.Windows.Forms.TextBox();
            this.title_text = new System.Windows.Forms.TextBox();
            this.rating_text = new System.Windows.Forms.TextBox();
            this.movieid_label = new System.Windows.Forms.Label();
            this.moveid_text = new System.Windows.Forms.TextBox();
            this.update_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.addmoview_button = new System.Windows.Forms.Button();
            this.movie_Grid = new System.Windows.Forms.DataGridView();
            this.movieIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.copiesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moviesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet3 = new video.Database1DataSet3();
            this.moviesTableAdapter = new video.Database1DataSet3TableAdapters.MoviesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.movie_Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // genre_label
            // 
            this.genre_label.AutoSize = true;
            this.genre_label.Location = new System.Drawing.Point(168, 295);
            this.genre_label.Name = "genre_label";
            this.genre_label.Size = new System.Drawing.Size(48, 17);
            this.genre_label.TabIndex = 39;
            this.genre_label.Text = "Genre";
            // 
            // plot_label
            // 
            this.plot_label.AutoSize = true;
            this.plot_label.Location = new System.Drawing.Point(168, 256);
            this.plot_label.Name = "plot_label";
            this.plot_label.Size = new System.Drawing.Size(32, 17);
            this.plot_label.TabIndex = 38;
            this.plot_label.Text = "Plot";
            // 
            // copies_label
            // 
            this.copies_label.AutoSize = true;
            this.copies_label.Location = new System.Drawing.Point(168, 211);
            this.copies_label.Name = "copies_label";
            this.copies_label.Size = new System.Drawing.Size(51, 17);
            this.copies_label.TabIndex = 37;
            this.copies_label.Text = "Copies";
            // 
            // rentalcost_label
            // 
            this.rentalcost_label.AutoSize = true;
            this.rentalcost_label.Location = new System.Drawing.Point(149, 172);
            this.rentalcost_label.Name = "rentalcost_label";
            this.rentalcost_label.Size = new System.Drawing.Size(81, 17);
            this.rentalcost_label.TabIndex = 36;
            this.rentalcost_label.Text = "Rental Cost";
            // 
            // year_label
            // 
            this.year_label.AutoSize = true;
            this.year_label.Location = new System.Drawing.Point(181, 46);
            this.year_label.Name = "year_label";
            this.year_label.Size = new System.Drawing.Size(38, 17);
            this.year_label.TabIndex = 35;
            this.year_label.Text = "Year";
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Location = new System.Drawing.Point(184, 81);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(35, 17);
            this.title_label.TabIndex = 34;
            this.title_label.Text = "Title";
            // 
            // rating_label
            // 
            this.rating_label.AutoSize = true;
            this.rating_label.Location = new System.Drawing.Point(184, 127);
            this.rating_label.Name = "rating_label";
            this.rating_label.Size = new System.Drawing.Size(49, 17);
            this.rating_label.TabIndex = 33;
            this.rating_label.Text = "Rating";
            // 
            // genre_text
            // 
            this.genre_text.Location = new System.Drawing.Point(236, 290);
            this.genre_text.Name = "genre_text";
            this.genre_text.Size = new System.Drawing.Size(100, 22);
            this.genre_text.TabIndex = 32;
            // 
            // plot_text
            // 
            this.plot_text.Location = new System.Drawing.Point(236, 251);
            this.plot_text.Name = "plot_text";
            this.plot_text.Size = new System.Drawing.Size(100, 22);
            this.plot_text.TabIndex = 31;
            // 
            // copies_text
            // 
            this.copies_text.Location = new System.Drawing.Point(236, 206);
            this.copies_text.Name = "copies_text";
            this.copies_text.Size = new System.Drawing.Size(100, 22);
            this.copies_text.TabIndex = 30;
            // 
            // rentalcost_text
            // 
            this.rentalcost_text.Location = new System.Drawing.Point(236, 167);
            this.rentalcost_text.Name = "rentalcost_text";
            this.rentalcost_text.Size = new System.Drawing.Size(100, 22);
            this.rentalcost_text.TabIndex = 29;
            // 
            // year_text
            // 
            this.year_text.Location = new System.Drawing.Point(236, 41);
            this.year_text.Name = "year_text";
            this.year_text.Size = new System.Drawing.Size(100, 22);
            this.year_text.TabIndex = 28;
            // 
            // title_text
            // 
            this.title_text.Location = new System.Drawing.Point(236, 81);
            this.title_text.Name = "title_text";
            this.title_text.Size = new System.Drawing.Size(100, 22);
            this.title_text.TabIndex = 27;
            // 
            // rating_text
            // 
            this.rating_text.Location = new System.Drawing.Point(236, 127);
            this.rating_text.Name = "rating_text";
            this.rating_text.Size = new System.Drawing.Size(100, 22);
            this.rating_text.TabIndex = 26;
            // 
            // movieid_label
            // 
            this.movieid_label.AutoSize = true;
            this.movieid_label.Location = new System.Drawing.Point(172, 13);
            this.movieid_label.Name = "movieid_label";
            this.movieid_label.Size = new System.Drawing.Size(58, 17);
            this.movieid_label.TabIndex = 25;
            this.movieid_label.Text = "MovieID";
            // 
            // moveid_text
            // 
            this.moveid_text.Enabled = false;
            this.moveid_text.Location = new System.Drawing.Point(236, 13);
            this.moveid_text.Name = "moveid_text";
            this.moveid_text.Size = new System.Drawing.Size(100, 22);
            this.moveid_text.TabIndex = 24;
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(264, 332);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(113, 45);
            this.update_button.TabIndex = 23;
            this.update_button.Text = "Update Movie";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.button6_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(160, 332);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(98, 45);
            this.delete_button.TabIndex = 22;
            this.delete_button.Text = "Delete Movie";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.button5_Click);
            // 
            // addmoview_button
            // 
            this.addmoview_button.Location = new System.Drawing.Point(39, 332);
            this.addmoview_button.Name = "addmoview_button";
            this.addmoview_button.Size = new System.Drawing.Size(115, 45);
            this.addmoview_button.TabIndex = 21;
            this.addmoview_button.Text = "Add Movie";
            this.addmoview_button.UseVisualStyleBackColor = true;
            this.addmoview_button.Click += new System.EventHandler(this.button4_Click);
            // 
            // movie_Grid
            // 
            this.movie_Grid.AutoGenerateColumns = false;
            this.movie_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movie_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.movieIDDataGridViewTextBoxColumn,
            this.ratingDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.rentalCostDataGridViewTextBoxColumn,
            this.copiesDataGridViewTextBoxColumn,
            this.plotDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn});
            this.movie_Grid.DataSource = this.moviesBindingSource;
            this.movie_Grid.Location = new System.Drawing.Point(383, 12);
            this.movie_Grid.Name = "movie_Grid";
            this.movie_Grid.RowTemplate.Height = 24;
            this.movie_Grid.Size = new System.Drawing.Size(512, 365);
            this.movie_Grid.TabIndex = 20;
            this.movie_Grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // movieIDDataGridViewTextBoxColumn
            // 
            this.movieIDDataGridViewTextBoxColumn.DataPropertyName = "MovieID";
            this.movieIDDataGridViewTextBoxColumn.HeaderText = "MovieID";
            this.movieIDDataGridViewTextBoxColumn.Name = "movieIDDataGridViewTextBoxColumn";
            this.movieIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ratingDataGridViewTextBoxColumn
            // 
            this.ratingDataGridViewTextBoxColumn.DataPropertyName = "Rating";
            this.ratingDataGridViewTextBoxColumn.HeaderText = "Rating";
            this.ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            // 
            // rentalCostDataGridViewTextBoxColumn
            // 
            this.rentalCostDataGridViewTextBoxColumn.DataPropertyName = "Rental_Cost";
            this.rentalCostDataGridViewTextBoxColumn.HeaderText = "Rental_Cost";
            this.rentalCostDataGridViewTextBoxColumn.Name = "rentalCostDataGridViewTextBoxColumn";
            // 
            // copiesDataGridViewTextBoxColumn
            // 
            this.copiesDataGridViewTextBoxColumn.DataPropertyName = "Copies";
            this.copiesDataGridViewTextBoxColumn.HeaderText = "Copies";
            this.copiesDataGridViewTextBoxColumn.Name = "copiesDataGridViewTextBoxColumn";
            // 
            // plotDataGridViewTextBoxColumn
            // 
            this.plotDataGridViewTextBoxColumn.DataPropertyName = "Plot";
            this.plotDataGridViewTextBoxColumn.HeaderText = "Plot";
            this.plotDataGridViewTextBoxColumn.Name = "plotDataGridViewTextBoxColumn";
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            // 
            // moviesBindingSource
            // 
            this.moviesBindingSource.DataMember = "Movies";
            this.moviesBindingSource.DataSource = this.database1DataSet3;
            // 
            // database1DataSet3
            // 
            this.database1DataSet3.DataSetName = "Database1DataSet3";
            this.database1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // moviesTableAdapter
            // 
            this.moviesTableAdapter.ClearBeforeFill = true;
            // 
            // Movies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 430);
            this.Controls.Add(this.genre_label);
            this.Controls.Add(this.plot_label);
            this.Controls.Add(this.copies_label);
            this.Controls.Add(this.rentalcost_label);
            this.Controls.Add(this.year_label);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.rating_label);
            this.Controls.Add(this.genre_text);
            this.Controls.Add(this.plot_text);
            this.Controls.Add(this.copies_text);
            this.Controls.Add(this.rentalcost_text);
            this.Controls.Add(this.year_text);
            this.Controls.Add(this.title_text);
            this.Controls.Add(this.rating_text);
            this.Controls.Add(this.movieid_label);
            this.Controls.Add(this.moveid_text);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.addmoview_button);
            this.Controls.Add(this.movie_Grid);
            this.Name = "Movies";
            this.Text = "Movies";
            this.Load += new System.EventHandler(this.Movies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movie_Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label genre_label;
        private System.Windows.Forms.Label plot_label;
        private System.Windows.Forms.Label copies_label;
        private System.Windows.Forms.Label rentalcost_label;
        private System.Windows.Forms.Label year_label;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label rating_label;
        private System.Windows.Forms.TextBox genre_text;
        private System.Windows.Forms.TextBox plot_text;
        private System.Windows.Forms.TextBox copies_text;
        private System.Windows.Forms.TextBox rentalcost_text;
        private System.Windows.Forms.TextBox year_text;
        private System.Windows.Forms.TextBox title_text;
        private System.Windows.Forms.TextBox rating_text;
        private System.Windows.Forms.Label movieid_label;
        private System.Windows.Forms.TextBox moveid_text;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button addmoview_button;
        private System.Windows.Forms.DataGridView movie_Grid;
        private Database1DataSet3 database1DataSet3;
        private System.Windows.Forms.BindingSource moviesBindingSource;
        private Database1DataSet3TableAdapters.MoviesTableAdapter moviesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn copiesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
    }
}