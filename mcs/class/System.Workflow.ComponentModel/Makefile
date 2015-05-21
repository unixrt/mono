thisdir = class/System.Workflow.ComponentModel
SUBDIRS = 
include ../../build/rules.make

LIBRARY = System.Workflow.ComponentModel.dll
LIB_REFS = 	Accessibility \
		Microsoft.Build.Framework \
		Microsoft.Build.Tasks.v4.0 \
		Microsoft.Build.Utilities.v4.0 \
		System \
		System.Configuration \
		System.Core \
		System.Data \
		System.Design \
		System.Drawing \
		System.Runtime.Serialization \
		System.Transactions \
		System.Windows.Forms \
		Microsoft.CSharp \
		System.Xml
LIB_MCS_FLAGS = /unsafe 
#/res:System.Activities.SR.resources /res:System.Activities.TD.resources

ifeq (true, $(GENERATE_RESOURCES))
LIB_MCS_FLAGS += /define:GENERATING_RESOURCES
endif

#RESX_RESOURCES = \
#		System.Activities.SR.resources \
#		System.Activities.TD.resources

CLEAN_FILES += $(RESX_RESOURCES)

RESOURCES = $(RESX_RESOURCES)

PREBUILT = $(RESX_RESOURCES:=.prebuilt)


TEST_MCS_FLAGS = $(LIB_MCS_FLAGS)

EXTRA_DISTFILES = more_build_args $(RESX_RESOURCES:.resources=.resx) $(PREBUILT)

include ../../build/library.make

$(the_lib): $(RESOURCES)

$(RESX_RESOURCES): %.resources: %.resx
	$(RESGEN) $< || cp $@.prebuilt $@

$(PREBUILT): %.prebuilt: %
	cp $* $@

dist-default: $(PREBUILT)

