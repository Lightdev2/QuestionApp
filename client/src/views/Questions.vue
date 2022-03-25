<template>
  <div class="questions">
    <div class="questions__main">
      <div class="questions__head">
        <q-title> All questions </q-title>
        <primary-button>
          <template #label> Ask Question </template>
        </primary-button>
      </div>
      <div class="questions__tools">
        <span class="questions__counter">410,286 questions</span>
        <div class="questions__tools-right">
          <tabs-component
            :tabs="tabs"
            class="questions__tabs"
            :active-tab="activeTab"
          />
          <primary-button @click="toggleShowFilter">
            <template #label>
              <span class="questions__btn"> <filter-icon />Filter </span>
            </template>
          </primary-button>
        </div>
      </div>
      <transition name="slide-fade">
        <div class="questions__filter" v-if="isShowFilter">
          <div class="questions__filter-body">
            <div>
              <span class="questions__filter-title">Filtering</span>
              <checkbox
                class="questions__filter-control"
                v-for="mode in filterModes"
                :key="mode"
                v-model="filters"
                :array-value="mode"
              >
                <template #label>
                  {{ mode }}
                </template>
              </checkbox>
            </div>
            <div>
              <span class="questions__filter-title">Sorting</span>
              <radio-button
                class="questions__filter-control"
                v-for="mode in sortModes"
                :key="mode"
                :array-value="mode"
                v-model="sortMode"
              >
                <template #label>
                  {{ mode }}
                </template>
              </radio-button>
            </div>
            <div>
              <span class="questions__filter-title">Tags</span>
              <radio-button
                class="questions__filter-control"
                v-for="mode in tagModes"
                :key="mode"
                :array-value="mode"
                v-model="tagMode"
              >
                <template #label>
                  {{ mode }}
                </template>
              </radio-button>
              <q-input placeholder="Javascript, go, etc" />
            </div>
          </div>
          <div class="questions__filter-footer">
            <primary-button>
              <template #label> Search </template>
            </primary-button>
            <flat-button @click="toggleShowFilter">
              <template #label> Cancel </template>
            </flat-button>
          </div>
        </div>
      </transition>

      <div>
        <question v-for="i in 20" :key="i" />
      </div>
      <div class="questions__pagination">
        <pagination-component
          :count="pagesCount"
          :current="curPage"
          @next="nextPage"
        />
      </div>
    </div>
    <right-sidebar>
      <template #content>
        <div class="questions__sidebar">
          <following-tags-block class="questions__sidebar-block" />
          <ignored-tags-block class="questions__sidebar-block" />
        </div>
      </template>
    </right-sidebar>
  </div>
</template>

<script>
import QTitle from "@/components/QTitle";
import PrimaryButton from "@/components/PrimaryButton";
import RightSidebar from "@/components/RightSidebar";
import IgnoredTagsBlock from "@/components/IgnoredTagsBlock.vue";
import FollowingTagsBlock from "@/components/FollowingTagsBlock.vue";
import TabsComponent from "@/components/TabsComponent.vue";
import Question from "@/components/Question.vue";
import PaginationComponent from "@/components/PaginationComponent";
import FilterIcon from "@/assets/filter.vue";
import Checkbox from "@/components/Checkbox";
import RadioButton from "@/components/RadioButton";
import FlatButton from "@/components/FlatButton";
import QInput from "@/components/QInput";
export default {
  name: "Questions",
  components: {
    QTitle,
    PrimaryButton,
    RightSidebar,
    IgnoredTagsBlock,
    FollowingTagsBlock,
    TabsComponent,
    FilterIcon,
    Question,
    PaginationComponent,
    Checkbox,
    RadioButton,
    FlatButton,
    QInput,
  },
};
</script>

<script setup>
import { ref } from "vue";
const tabs = ["New", "Answered", "Rating", "Unanswered"];
const activeTab = tabs[0];
const sortModes = ["New", "Update", "Raiting", "Views"];
const tagModes = ["Followed", "Tags below:"];
const filterModes = ["Have answer", "No asnwer"];
const tagMode = ref(tagModes[0]);
const sortMode = ref(sortModes[0]);
const filters = ref([]);
const pagesCount = ref(100);
const isShowFilter = ref(false);
const toggleShowFilter = () => (isShowFilter.value = !isShowFilter.value);
const curPage = ref(1);
const nextPage = (_page) => {
  curPage.value = _page;
};
</script>

<style scoped lang="scss">
.questions {
  display: flex;
  width: 100%;
  &__main {
    flex-grow: 1;
  }
  &__head {
    display: flex;
    justify-content: space-between;
    margin-left: 10px;
  }
  &__counter {
    color: var(--black700);
    font-size: 1.30769231rem;
  }
  &__sidebar {
    padding-left: 10px;
  }
  &__tools {
    display: flex;
    justify-content: space-between;
    margin-left: 10px;
    margin-bottom: 1rem;
    margin-top: 2rem;
    align-items: center;
  }
  &__tabs {
    margin-right: 1rem;
  }
  &__btn {
    display: flex;
    align-items: center;
    svg {
      margin-right: 5px;
      fill: var(--powder700);
    }
  }
  &__tools-right {
    display: flex;
  }
  &__sidebar-block {
    margin-bottom: 1rem;
  }
  &__pagination {
    display: flex;
    justify-content: flex-end;
    margin-bottom: 1rem;
  }
  &__filter {
    background-color: var(--black50);
    border-radius: 5px;
    margin-bottom: 1rem;
    margin-left: 10px;
    color: var(--black900);
    font-size: 14px;
    border: 1px solid var(--black200);
  }
  &__filter-body {
    display: flex;
    justify-content: space-between;
    padding: 1rem;
  }
  &__filter-title {
    font-weight: 700;
    font-size: 16px;
    display: block;
    margin-bottom: 0.6rem;
  }
  &__filter-footer {
    display: flex;
    justify-content: space-between;
    align-items: center;
    border-top: 1px solid var(--black200);
    padding: 5px 1rem;
  }
  &__filter-control {
    margin-bottom: 7px;
  }
}

.slide-fade-enter-active {
  transition: all 0.2s ease-out;
}

.slide-fade-leave-active {
  transition: all 0.2s cubic-bezier(1, 0.5, 0.8, 1);
}

.slide-fade-enter-from,
.slide-fade-leave-to {
  transform: translateY(-20px);
  opacity: 0;
}
</style>
