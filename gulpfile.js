/// <vs AfterBuild='build' />
'use strict';
var config 			    = require('./build/config.json');
var gulp                = require('gulp');
var log                 = require('./build/logger.js');
var generateJS			= require('./build/compile-ts/compile-ts-task');
var generateCss         = require('./build/compile-scss/compile-scss-task');
var cleanCode           = require('./build/clean/clean-task');
var runSequence         = require('run-sequence');
//var uglify        	= require('./build/uglify/uglify-task');

gulp.task('watch', ['build-dev'], function () {
	gulp.watch(config.tsGlob, ['compile-ts-dev']);
	gulp.watch(config.scssGlob, ['compile-scss']);
});

gulp.task('build', function(callback)
{
	runSequence('clean-js', 'clean-css', ['compile-ts', 'compile-scss'], callback);
});

gulp.task('build-dev', function (callback) {
	runSequence('clean-js', 'clean-css', ['compile-ts-dev', 'compile-scss'], callback);
});

gulp.task('default', ['build']);
