'use strict';
var gulp   			= require('gulp');
var sass   			= require('gulp-ruby-sass');
var prefix 			= require('gulp-autoprefixer');
var config 			= require('../config.json');
var errorHandler	= require('../errorHandler');

gulp.task('compile-scss', function () {
	return sass(config.stylesRoot, { style: 'expanded' })
		.on('error', errorHandler)
		.pipe(prefix(config.autoprefixerBrowserSupport).on('error', errorHandler))
		.pipe(gulp.dest(config.stylesRoot));
});
